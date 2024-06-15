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
using System.Globalization;
using System.Runtime.CompilerServices;

namespace CapaDatos
{
    public class Datos {
        private static string strCon;
        private static OleDbCommand cmd = new OleDbCommand();
        private static OleDbDataAdapter da;
        private static OleDbConnection conn;
        private static DataSet ds;

        public static void setConnectionDBPath(string path)
        {
            string databasePath = path + "\\ClubDeportivoDB.mdb";

            string access64Provider = "Microsoft.ACE.OLEDB.12.0";
            // string access32Provider = "Microsoft.Jet.OLEDB.4.0";

            strCon = "Provider="+ access64Provider + ";Data Source= " + databasePath;
        }
        public static List<object> obtenerActividadesInscriptasPara(string idSocio) {
            // Método para obtener las actividades en las que se encuentra inscripto un usuario (solo las actividades, no sus pagos)
            return null;
        }
        public static void inscripcionEnActividad(string idSocio, string actividadId) {
            // método para que un usuario pueda registrarse en una actividad.
        }

        // Método para obtener las actividades a las que el socio con idSocio no registra un pago a la fecha actual
        public static List<string> obtenerActividadesNoinscriptasPara(string idSocio) {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");

            return list;
        }

        public static bool getActividadesDeportivas(List<ArrayList> actividadesDeportivas, ref string errorMessage)
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
                errorMessage = ex.Message;
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void actualizarCantAlumnosInscriptosActividadDeportivaDB(string nombreAD, int nuevaCantAlumnosInscriptos)
        {
            string queryUpdate = "UPDATE ActividadDeportiva " +
                                 "SET cantAlumnosInscriptos = @CantAlumnosInscriptos " +
                                 "WHERE ActividadDeportiva.nombreActividad = @nombreAD ";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    
                    using (OleDbCommand cmdUpdate = new OleDbCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@CantAlumnosInscriptos", nuevaCantAlumnosInscriptos);
                        cmdUpdate.Parameters.AddWithValue("@nombreAD", nombreAD);

                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public static bool getSocios(List<ArrayList> socios,ref string errorMessage)
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
                errorMessage = ex.Message;
                Console.WriteLine(errorMessage);
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

        public static string getIDActividadDeportiva(string nombreAD)
        {
            string idActDep = null;

            string query = "SELECT idActDeportiva FROM ActividadDeportiva WHERE nombreActividad = @nombreAD";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreAD", nombreAD);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idActDep = reader["idActDeportiva"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return idActDep;
        }

        // Para loguear socio
        public static string getIDSocio(string dniSocio)
        {
            string idSocio = null;

            string query = "SELECT idSocio FROM Socio WHERE dni = @dniSocio";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dniSocio", dniSocio);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idSocio = reader["idSocio"].ToString();
                            }
                        }
                    }
                }
                return idSocio;
            }
            catch (Exception ex)
            {
                return strCon + " - exception: " + ex;
            }

        }

        public static string getIdUltimoPagoRegistrado()
        {
            string idPago = null;
            try
            {
                string strCmd = "SELECT TOP 1 idPago FROM Pago ORDER BY idPago DESC";

                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open(); // abre conexion

                    using (OleDbCommand cmd = new OleDbCommand(strCmd, conn)) // le asigno al cmd la query y la conexión ya establecida
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPago = reader["IdPago"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                string error = ex.Message;
            }
            return idPago;
        }

        // Para registrar un nuevo socio
        public static void guardarSocio(ArrayList datos)
        {
            if (datos != null && datos.Count == 6)// cada 6 elementos es un socio
            {
                try
                {
                    string Dni = datos[0].ToString();
                    string Nombre = datos[1].ToString();
                    string Apellido = datos[2].ToString();
                    string Email = datos[3].ToString();
                    string Telefono = datos[4].ToString();
                    DateTime FechaNacimiento = DateTime.Parse(datos[5].ToString());

                    string strCmd = "INSERT INTO Socio (dni, nombre, apellido, email, telefono, fechaNacimiento) " +
                                    "VALUES (@Dni, @Nombre, @Apellido, @Email, @Telefono, @FechaNacimiento)";

                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open(); // abre conexion

                        using (OleDbCommand cmd = new OleDbCommand(strCmd, conn)) // le asigno al cmd la query y la conexión ya establecida
                        {
                            cmd.Parameters.Add("@Dni", OleDbType.VarChar).Value = Dni;
                            cmd.Parameters.Add("@Nombre", OleDbType.VarChar).Value = Nombre;
                            cmd.Parameters.Add("@Apellido", OleDbType.VarChar).Value = Apellido;
                            cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email;
                            cmd.Parameters.Add("@Telefono", OleDbType.VarChar).Value = Telefono;
                            cmd.Parameters.Add("@FechaNacimiento", OleDbType.Date).Value = FechaNacimiento;

                            cmd.ExecuteNonQuery(); //se lleva a cabo el guardado
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    string error = ex.Message;
                }
            }
        }

        // Inscribirse en una actividad
        public static void guardarPagoActividadDeportivaSocio(ArrayList datos)
        {
            //Se requirere guardar los datos en la tabla Pago y en la tabla PagoActividadDeportiva

            if (datos != null && datos.Count == 5) {
                try {
                    string pagoFinal = datos[0].ToString();
                    DateTime fechaPago = DateTime.Parse(datos[1].ToString());
                    string idActDep = datos[2].ToString();
                    string idSocio = datos[3].ToString();
                    int idPago = int.Parse(datos[4].ToString());

                    string strCmd = "INSERT INTO Pago (idPago, pagoFinal, fechaPago, idSocio) " +
                                    "VALUES (@idPago, @PagoFinal, @FechaPago, @IdSocio) ";

                    string strCmd2 = "INSERT INTO PagoActividadDeportiva (idActDeportiva, idPago) " +
                                     "VALUES (@IdActDeportiva, @IdPago) ";

                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open(); // abre conexion

                        using (OleDbCommand cmd = new OleDbCommand(strCmd, conn))
                        {
                            cmd.Parameters.Add("idPago", OleDbType.VarChar).Value = idPago;
                            cmd.Parameters.Add("@PagoFinal", OleDbType.VarChar).Value = pagoFinal;
                            cmd.Parameters.Add("@FechaPago", OleDbType.Date).Value = fechaPago;
                            cmd.Parameters.Add("@IdSocio", OleDbType.VarChar).Value = idSocio;

                            cmd.ExecuteNonQuery(); //se lleva a cabo el guardado
                        }
                    }

                    //string idPago = getIdUltimoPagoRegistrado();

                    using (OleDbConnection conn = new OleDbConnection(strCon)) 
                    {
                        conn.Open(); // abre conexion

                        using (OleDbCommand cmd = new OleDbCommand(strCmd2, conn))
                        {
                            cmd.Parameters.Add("@IdActDeportiva", OleDbType.VarChar).Value = idActDep;
                            cmd.Parameters.Add("@IdPago", OleDbType.VarChar).Value = idPago;

                            cmd.ExecuteNonQuery(); //se lleva a cabo el guardado
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    string error = ex.Message;
                }
            }

        }

        public static void guardarPagoCuotaSocial(ArrayList datos)
        {
            if (datos != null && datos.Count == 7)
            {
                try
                {
                    string pagoFinal = datos[0].ToString();
                    DateTime fechaPago = DateTime.Parse(datos[1].ToString());
                    string idSocio = datos[2].ToString();
                    string precioMesDato = datos[3].ToString();
                    string maxActividadesGratuitas = datos[4].ToString();
                    string cantActividadesDeCuotaSocial = datos[5].ToString();
                    int idPago = int.Parse(datos[6].ToString());

                    string strCmd = "INSERT INTO Pago (idPago, pagoFinal, fechaPago, idSocio) " +
                                    "VALUES (@idPago, @PagoFinal, @FechaPago, @IdSocio)";

                    string strCmd2 = "INSERT INTO PagoCuotaSocial (PrecioMensualData, MaxActividadesGratuitas, cantActividadesDeCuotaSocial, idPago) " +
                                    "VALUES (@PrecioMensualData, @MaxActividadesGratuitas, @cantActividadesDeCuotaSocial, @idPago)";

                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open(); // abre conexion

                        using (OleDbCommand cmd = new OleDbCommand(strCmd, conn))
                        {
                            cmd.Parameters.Add("idPago", OleDbType.VarChar).Value = idPago;
                            cmd.Parameters.Add("@PagoFinal", OleDbType.VarChar).Value = pagoFinal;
                            cmd.Parameters.Add("@FechaPago", OleDbType.Date).Value = fechaPago;
                            cmd.Parameters.Add("@IdSocio", OleDbType.VarChar).Value = idSocio;

                            cmd.ExecuteNonQuery(); //se lleva a cabo el guardado
                        }

                    }

                    //string idPago = getIdUltimoPagoRegistrado();

                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open(); // abre conexion
                        using (OleDbCommand cmd = new OleDbCommand(strCmd2, conn))
                        {
                            cmd.Parameters.Add("@PrecioMensualData", OleDbType.VarChar).Value = precioMesDato;
                            cmd.Parameters.Add("@MaxActividadesGratuitas", OleDbType.VarChar).Value = maxActividadesGratuitas;
                            cmd.Parameters.Add("@cantActividadesDeCuotaSocial", OleDbType.VarChar).Value = cantActividadesDeCuotaSocial;
                            cmd.Parameters.Add("@idPago", OleDbType.VarChar).Value = idPago;

                            cmd.ExecuteNonQuery(); //se lleva a cabo el guardado

                        }
                    }        
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    string error = ex.Message;
                }

            }
        }

        public static void actualizarCantActAsociadasPagoCuotaSocialDB(int idPago, int nuevaCantidadActividades)
        {
            int idPagoCuotaSocial = -1;

            string querySelect = "SELECT PagoCuotaSocial.idPagoCuotaSocial " +
                                 "FROM Pago " +
                                 "INNER JOIN PagoCuotaSocial ON PagoCuotaSocial.idPago = Pago.idPago " +
                                 "WHERE Pago.idPago = @IdPago";

            string queryUpdate = "UPDATE PagoCuotaSocial " +
                                 "SET cantActividadesDeCuotaSocial = @CantActividadesDeCuotaSocial " +
                                 "WHERE idPagoCuotaSocial = @IdPagoCuotaSocial ";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();

                    // Ejecutar SELECT
                    using (OleDbCommand cmdSelect = new OleDbCommand(querySelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@IdPago", idPago);

                        using (OleDbDataReader reader = cmdSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPagoCuotaSocial = Convert.ToInt32(reader["idPagoCuotaSocial"]);
                            }
                        }
                    }

                    // Si se encontró el idPagoCuotaSocial, ejecutar UPDATE
                    if (idPagoCuotaSocial != -1)
                    {
                        using (OleDbCommand cmdUpdate = new OleDbCommand(queryUpdate, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@CantActividadesDeCuotaSocial", nuevaCantidadActividades);
                            cmdUpdate.Parameters.AddWithValue("@IdPagoCuotaSocial", idPagoCuotaSocial);

                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el registro de PagoCuotaSocial para actualizar.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}