using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaDatos
{
    public class Datos {
        private static string strCon;
        private static OleDbCommand cmd;
        private static OleDbDataAdapter da;
        private static OleDbConnection conn;
        private static DataSet ds;
        public static void setConnectionDBPath(string path)
        {
            string databasePath = path + @"\ClubDeportivoDB.mdb";
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + databasePath;
        }

        public static bool getSocios(List<ArrayList> socios)
        {
            ArrayList socio;
            ArrayList pagosCuotasSociales;

            string query = "SELECT * FROM Socio";
            try
            {
                conn = new OleDbConnection(strCon);  //Crear instancia de la conexión
                conn.Open();
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                ds = new DataSet();
                da.Fill(ds);  //Guardo la data obtenida

                for(int i=0; i < ds.Tables[0].Rows.Count; i++)
                {
                    socio = new ArrayList();
                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while(enumerator.MoveNext())
                    {
                        socio.Add(enumerator.Current);
                    }

                    //Obtener datos de sus PagosCuotasSociales
                    pagosCuotasSociales = new ArrayList();
                    getCuotasSocialesSocio(socio[0],pagosCuotasSociales);

                    socios.Add(socio);
                }
                
                return true;
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool getCuotasSocialesSocio(object idSocio,ArrayList pagosCuotasSociales)
        {
            ArrayList pagoCuotaSocial;

            string query = "SELECT * FROM PagoCuotaSocial pcs INNER JOIN Pago p ON p.idPago = pcs.idPago WHERE p.idSocio = " + idSocio;

            try
            {
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                DataSet ds2 = new DataSet();
                da.Fill(ds2);  //Guardo la data obtenida

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    pagoCuotaSocial = new ArrayList();

                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        pagoCuotaSocial.Add(enumerator.Current);
                    }
                    pagosCuotasSociales.Add(pagoCuotaSocial);

                    Console.WriteLine(pagoCuotaSocial.Count);         //Mostrar datos para ver que tiene (parece que esta guardado dentro la info del usario, no del pago cuaota social)
                }
                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }   
        }
    }
}
