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
            string databasePath = path + @"\Data\BDClubDeportivo.accdb";

            strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath;
            
        }

        public static bool getSocios(List<ArrayList> socios)
        {
            ArrayList socio;

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

                    socios.Add(socio);
                }

                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }
    }
}
