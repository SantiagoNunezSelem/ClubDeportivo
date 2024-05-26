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
    public class Datos
    {
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

        public static bool getActividadesDeportivas(List<ArrayList> actividadesDeportivas)
        {
            ArrayList actDep;
            string query = "SELECT * FROM ActividadDeportiva";
            try
            {
                conn = new OleDbConnection(strCon);  //Crear instancia de la conexión
                conn.Open();
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                ds = new DataSet();
                da.Fill(ds);  //Guardo la data obtenida

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    actDep = new ArrayList();
                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        actDep.Add(enumerator.Current);
                    }
                    actividadesDeportivas.Add(actDep);
                }

                return true;
            }
            catch (Exception ex)
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


        public static bool getSocios(List<ArrayList> socios)
        {
            ArrayList socio;
            List<ArrayList> pagosCuotasSociales;
            List<ArrayList> pagosActivDep;

            string query = "SELECT * FROM Socio";
            try
            {
                conn = new OleDbConnection(strCon);  //Crear instancia de la conexión
                conn.Open();
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                ds = new DataSet();
                da.Fill(ds);  //Guardo la data obtenida

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    socio = new ArrayList();
                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        socio.Add(enumerator.Current);
                    }

                    //Obtener datos de sus PagosCuotasSociales
                    pagosCuotasSociales = new List<ArrayList>();
                    getCuotasSocialesSocio(socio[0], pagosCuotasSociales);
                    socio.Add(pagosCuotasSociales); //Guardar los pagos en socio

                    //Obtener datos de sus PagosActividadesDeportivas
                    pagosActivDep = new List<ArrayList>();
                    getPagosActividadDeportiva(socio[0], pagosActivDep);
                    socio.Add(pagosActivDep);

                    socios.Add(socio);
                }

                return true;
            }
            catch (Exception ex)
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

        public static bool getCuotasSocialesSocio(object idSocio, List<ArrayList> pagosCuotasSociales)
        {
            ArrayList pagoCuotaSocial;

            string query = "SELECT Pago.*, PagoCuotaSocial.* " +
                           "FROM Pago INNER JOIN PagoCuotaSocial " +
                           "ON Pago.idPago = PagoCuotaSocial.idPago " +
                           "WHERE Pago.idSocio = " + idSocio;

            try
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter(query, conn); //Ejecuta la query con la conexión existente

                DataSet ds2 = new DataSet();
                da2.Fill(ds2);  //Guardo la data obtenida

                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    pagoCuotaSocial = new ArrayList();

                    IEnumerator enumerator = ds2.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        pagoCuotaSocial.Add(enumerator.Current);
                    }
                    pagosCuotasSociales.Add(pagoCuotaSocial);

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

        public static bool getPagosActividadDeportiva(object idSocio, List<ArrayList> pagosActivDep)
        {
            ArrayList pagoActividadDeportiva;
            
            string query = "SELECT Pago.*, PagoActividadDeportiva.*, ActividadDeportiva.* " +
                           "FROM (Pago INNER JOIN PagoActividadDeportiva " +
                           "ON Pago.idPago = PagoActividadDeportiva.idPago) " +
                           "INNER JOIN ActividadDeportiva ON PagoActividadDeportiva.idActDeportiva = ActividadDeportiva.idActDeportiva " +
                           "WHERE Pago.idSocio = " + idSocio;

            try
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter(query, conn); //Ejecuta la query con la conexión existente

                DataSet ds2 = new DataSet();
                da2.Fill(ds2);  //Guardo la data obtenida

                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    pagoActividadDeportiva = new ArrayList();

                    IEnumerator enumerator = ds2.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        pagoActividadDeportiva.Add(enumerator.Current);
                    }
                    pagosActivDep.Add(pagoActividadDeportiva);

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
