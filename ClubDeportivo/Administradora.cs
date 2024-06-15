using CapaDatos;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Administradora {
        private static Administradora instancia;
        private List<Socio> socios;
        private List<Pago> pagos;
        private List<ActividadDeportiva> actividadesDeportivas;
        public Administradora() {
            socios = new List<Socio>();
            pagos = new List<Pago>();
            actividadesDeportivas = new List<ActividadDeportiva>();
        }

        public static bool validateUser(string id, string dni) {
            String _id = Datos.getIDSocio(dni);

            return _id == id;
        }
        public void agregarActividadDeportiva(ActividadDeportiva ad)
        {
            actividadesDeportivas.Add(ad);
        }

        public Socio buscarSocio(string dni)
        {
            Socio socioEncontrado = socios.Find(socio => socio.Dni == dni);

            return socioEncontrado;
        }

        public void agregarSocio(Socio socio) 
        {
            socios.Add(socio);
        }

        public void eliminarSocio(string dni)
        {
            Socio socioEliminar = buscarSocio(dni);
            if(socioEliminar != null)
            {
                socios.Remove(socioEliminar);
            }
        }

        public ActividadDeportiva buscarActividadDeportiva(string nombre)
        {
            ActividadDeportiva ad = actividadesDeportivas.Find(actividad => actividad.Nombre == nombre);
            return ad;
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad)
        {
            pagos.Add(pagoActividad);

            Socio socioDeActividad = pagoActividad.Socio;
            ActividadDeportiva actividadDep = pagoActividad.ActividadDeportivaInfo;

            //Registrar el pago de la actividad a la lista de pagos del socio
            socioDeActividad.agregarPagoActividadDeportiva(pagoActividad);

            //Agregar el Socio a la actividad deportiva (-1 vacante)
            actividadDep.agregarAlumno();
        }

        public decimal getPrecioMesCuotaSocial()
        {
            return PagoCuotaSocial.PrecioMensual;
        }

        public void agregarPagoCuotaSocial(PagoCuotaSocial pagoCS)
        {
            pagos.Add(pagoCS);

            //Registrar el pago de la cuota social a su lista de pagos
            pagoCS.Socio.agregarPagoCuotaSocial(pagoCS);
        }

        public decimal getPrecioActividadDeportiva(Socio socio, ActividadDeportiva actDep)
        {
            PagoCuotaSocial pagoCuotaSocial = socio.buscarCuotaSocialActualActiva();
            if(pagoCuotaSocial != null)
            {
                //Tiene una cuota social activa:
                //1) Si tiene registrado menos de 5 actividades -> precioActividad = 0
                //2) Si tiene 5 o mas -> precioActividad = precioActividad - 50%
                int cantActividades = pagoCuotaSocial.getCantActividadesDeCuotaSocial();
                if(cantActividades < 5)
                {
                    return 0; //El precio es $0
                }
                else
                {
                    return actDep.PrecioMes * 0.5m; //50 off del precio
                }
            }
            else
            {
                return actDep.PrecioMes; //Precio sin descuento
            }
        }

        public static Administradora ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Administradora();
            }
            return instancia;
        }

        public static void staticSetConnectionDBPath(string path) {
            string originalPath = path; //hago una copia de la direccion original para adaptarla

            string projectRoot = Directory.GetParent(originalPath).Parent.FullName; //de esta manera estoy parado en ClubDeportivo

            // Ahora, estando en ClubDeportivo busco una carpeta llamada "CapaDatos"
            string newPath = Path.Combine(projectRoot, "CapaDatos"); //de esta manera estoy parado donde temenemos la BBDD.

            Datos.setConnectionDBPath(newPath);
        }

        public void setConnectionDBPath(string path)
        {
            //Originalmente va a traer un directorio del tipo ->    C:\Users\NICOLE\source\repos\ClubDeportivo\CapaUsuario\bin\Debug
            //esto se debe a que toma la direccion donde se esta ejecutando, en este caso, capa usuario.
            //hay que acomodarlo para llegar a la capa de datos->   C:\Users\NICOLE\source\repos\ClubDeportivo\CapaDatos

            string originalPath = path; //hago una copia de la direccion original para adaptarla

            // Parent = te mueve a una carpeta padre, al usarla una vez nos vemos a /CapaUsuario y con la segunda a /ClubDeportivo
            string projectRoot = Directory.GetParent(originalPath).Parent.Parent.FullName; //de esta manera estoy parado en ClubDeportivo

            // Ahora, estando en ClubDeportivo busco una carpeta llamada "CapaDatos"
            string newPath = Path.Combine(projectRoot, "CapaDatos"); //de esta manera estoy parado donde temenemos la BBDD.

            Datos.setConnectionDBPath(newPath);
        }

        public bool getActividadesDeportivasDB(ref string errorMessage)
        {
            List<ArrayList> getActividadesDep = new List<ArrayList>();
            if(Datos.getActividadesDeportivas(getActividadesDep, ref errorMessage))
            {

                foreach(ArrayList ad in getActividadesDep)
                {
                    string nombre = ad[1].ToString();
                    string nombreProfesor = ad[2].ToString();
                    string horario = ad[3].ToString();
                    int cantAluMax = int.Parse(ad[4].ToString());
                    decimal precio = decimal.Parse(ad[5].ToString());
                    int cantAluInscriptos = int.Parse(ad[6].ToString());

                    ActividadDeportiva createAD = new ActividadDeportiva(nombre, nombreProfesor, horario, cantAluMax, cantAluInscriptos, precio);

                    //Agregar actividades deportivas al arrayList de la Administradora
                    this.agregarActividadDeportiva(createAD);
                }
                return true;
            }
            else
            {
                //Error al realizar la consulta en la base de datos
                return false;
            }
        }

        public static List<object> obtenerActividadesInscriptasPara(string idSocio) {
            return Datos.obtenerActividadesInscriptasPara(idSocio);
        }

        public static List<string> obtenerIDdeActividadesDisponiblesPara(string idSocio) {
            return Datos.obtenerActividadesNoinscriptasPara(idSocio);
        }

        public static void inscripcionEnActividad(string idSocio, string actividadId) {
            Datos.inscripcionEnActividad(idSocio, actividadId);
        }

        public void agregarPagoActividadDeportivaGetDB(PagoActividadDeportiva pagoActividad)
        {
            //Este metodo permite agregar toda la informaci�n de un pago actividad deportiva obtenida de la base de datos
            //No se utiliza agregarPagoActividadDeportiva ya que no se debe ejecutar algunos metodos al estar obteniendo la data de la DB
            pagos.Add(pagoActividad); 

            Socio socioDeActividad = pagoActividad.Socio;
            ActividadDeportiva actividadDep = pagoActividad.ActividadDeportivaInfo;

            //Guardar el pago de la actividad a la lista de pagos del socio
            socioDeActividad.guardarPagoActividadDeportivaDeDB(pagoActividad);
        }

        public void actualizarCantAlumnosInscriptosActividadDeportivaDB(ActividadDeportiva pagoAD)
        {
            //La cantidad de alumnos inscriptos ya debe estar actualizada
            Datos.actualizarCantAlumnosInscriptosActividadDeportivaDB(pagoAD.Nombre, pagoAD.CantAlumnosInscriptos);
        }

        public bool getSociosDB(ref string errorMessage)
        {
            List<ArrayList> getSocios = new List<ArrayList>();
            if (Datos.getSocios(getSocios, ref errorMessage)){

                foreach (ArrayList socio in getSocios)
                {
                    string dni = socio[1].ToString();
                    string nombre = socio[2].ToString();
                    string apellido = socio[3].ToString();
                    string email = socio[4].ToString();
                    string telefono = socio[5].ToString();
                    DateTime fechaNacimiento = DateTime.Parse(socio[6].ToString());
                    List<ArrayList> listaPagosCuotasSociales = (List<ArrayList>)socio[7];
                    List<ArrayList> listaPagosActividadDeportiva = (List<ArrayList>)socio[8];

                    Socio createSocio = new Socio(dni, nombre, apellido, email, telefono, fechaNacimiento);

                    //Agregar los pagosCuotasSociales al socio
                    foreach(ArrayList pagoCS in listaPagosCuotasSociales)
                    {
                        int idPago = int.Parse(pagoCS[0].ToString());
                        decimal pagoFinal = decimal.Parse(pagoCS[1].ToString());
                        DateTime fechaPago = DateTime.Parse(pagoCS[2].ToString());

                        PagoCuotaSocial createPagoCuotaSocial = new PagoCuotaSocial(idPago, createSocio,pagoFinal,fechaPago);

                        this.agregarPagoCuotaSocial(createPagoCuotaSocial); //Puedo utilizar el mismo metodo para guardar data del sistema
                    }

                    //Agregar los pagosCuotasSociales al socio
                    foreach (ArrayList pagoAD in listaPagosActividadDeportiva)
                    {
                        int idPago = int.Parse(pagoAD[0].ToString());
                        decimal pagoFinal = decimal.Parse(pagoAD[1].ToString());
                        DateTime fechaPago = DateTime.Parse(pagoAD[2].ToString());
                        string nombreAD = pagoAD[8].ToString();

                        ActividadDeportiva actDep = this.buscarActividadDeportiva(nombreAD);

                        PagoActividadDeportiva createPagoAD = new PagoActividadDeportiva(idPago, createSocio, pagoFinal, fechaPago, actDep);

                        //Guardar la informaci�n en el sistema
                        this.agregarPagoActividadDeportivaGetDB(createPagoAD);
                    }

                    //Agregar socio al arrayList de la Administradora
                    this.agregarSocio(createSocio);
                }
                return true;
            }
            else
            {
                //Error al realizar la consulta en la base de datos 
                return false;
            }
        }

        public void guardarNuevoSocioDB(Socio nuevoSocio) 
        {
            ArrayList datosSocio = new ArrayList();
            datosSocio.Add(nuevoSocio.Dni);
            datosSocio.Add(nuevoSocio.Nombre);
            datosSocio.Add(nuevoSocio.Apellido);
            datosSocio.Add(nuevoSocio.Email);
            datosSocio.Add(nuevoSocio.Telefono);
            datosSocio.Add(nuevoSocio.FechaNacimiento.ToShortDateString()); // Convertir la fecha a formato corto

            // Recordar que al crear el socio el mismo no tiene asociado ningun pago
            Datos.guardarSocio(datosSocio);
        }

        public void guardarPagoActividadDeportivaSocioDB(PagoActividadDeportiva pagoActividad)
        {
            string nombreActDep = pagoActividad.ActividadDeportivaInfo.Nombre; //Para poder encontrar el id actividad deportiva (para la relacion en la base de datos)
            string idActDep = Datos.getIDActividadDeportiva(nombreActDep);

            string dniSocio = pagoActividad.Socio.Dni; //Para poder encontrar el id socio (para la relacion en la base de datos)
            string idSocio = Datos.getIDSocio(dniSocio);

            ArrayList datosPagoActividadDeportiva = new ArrayList();

            datosPagoActividadDeportiva.Add(pagoActividad.PagoFinal);
            datosPagoActividadDeportiva.Add(pagoActividad.FechaPago.ToShortDateString());
            datosPagoActividadDeportiva.Add(idActDep);
            datosPagoActividadDeportiva.Add(idSocio);
            datosPagoActividadDeportiva.Add(pagoActividad.IdPago);

            Datos.guardarPagoActividadDeportivaSocio(datosPagoActividadDeportiva);
        }

        public void guardarPagoCuotaSocialDB(PagoCuotaSocial pagoCS)
        {
            string dniSocio = pagoCS.Socio.Dni; //Para poder encontrar el id socio (para la relacion en la base de datos)
            string idSocio = Datos.getIDSocio(dniSocio);

            ArrayList datosPagoCuotaSocial = new ArrayList();
            datosPagoCuotaSocial.Add(pagoCS.PagoFinal);
            datosPagoCuotaSocial.Add(pagoCS.FechaPago.ToShortDateString());
            datosPagoCuotaSocial.Add(idSocio);
            datosPagoCuotaSocial.Add(PagoCuotaSocial.PrecioMensual);
            datosPagoCuotaSocial.Add(5); //Cantidad maxima de actividad deportivas descuento asociadas a cuotaSocial
            datosPagoCuotaSocial.Add(0);
            datosPagoCuotaSocial.Add(pagoCS.IdPago);

            Datos.guardarPagoCuotaSocial(datosPagoCuotaSocial);
        }

        public void guardarPagoActividadDeportivaSocio(PagoActividadDeportiva pagoActividad)
        {
            string nombreActDep = pagoActividad.ActividadDeportivaInfo.Nombre; //Para poder encontrar el id actividad deportiva (para la relacion en la base de datos)
            string idActDep = Datos.getIDActividadDeportiva(nombreActDep);

            string dniSocio = pagoActividad.Socio.Dni; //Para poder encontrar el id socio (para la relacion en la base de datos)
            string idSocio = Datos.getIDSocio(dniSocio);

            ArrayList datosPagoActividadDeportiva = new ArrayList();

            datosPagoActividadDeportiva.Add(pagoActividad.PagoFinal);
            datosPagoActividadDeportiva.Add(pagoActividad.FechaPago.ToShortDateString());
            datosPagoActividadDeportiva.Add(idActDep);
            datosPagoActividadDeportiva.Add(idSocio);

            Datos.guardarPagoActividadDeportivaSocio(datosPagoActividadDeportiva);
        }

    }
}
