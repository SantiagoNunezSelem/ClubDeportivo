using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class Administradora
    {
        private static Administradora instancia;
        private List<Socio> socios;
        private List<Pago> pagos;
        private List<ActividadDeportiva> actividadesDeportivas;
        private Administradora()
        {
            socios = new List<Socio>();
            pagos = new List<Pago>();
            actividadesDeportivas = new List<ActividadDeportiva>();

            //Solo por ahora para poder tener actividades deportivas las creo aca
            ActividadDeportiva natacion = new ActividadDeportiva("Natacion", "Pedro", "Lunes y Martes", 10, 20000);
            ActividadDeportiva voley = new ActividadDeportiva("Voley", "Maria", "Miercoles y Viernes", 8, 16000);
            ActividadDeportiva futbol = new ActividadDeportiva("Futbol", "Juan", "Domingos", 20, 18000);
            actividadesDeportivas.Add(natacion);
            actividadesDeportivas.Add(voley);
            actividadesDeportivas.Add(futbol);
        }

        public static Administradora ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Administradora();
            }
            return instancia;
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
            socios.Remove(socioEliminar);
        }

        public ActividadDeportiva buscarActividadDeportiva(string nombre)
        {
            ActividadDeportiva ad = actividadesDeportivas.Find(actividad => actividad.Nombre == nombre);
            return ad;
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad)
        {
            pagos.Add(pagoActividad);

            //Registrar el pago de la actividad a su lista de pagos
            pagoActividad.Socio.agregarPagoActividadDeportiva(pagoActividad);
        }

        public void mostrarSocios()
        {
            foreach(Socio socio in socios)
            {
                string dni = socio.Dni;

                Console.WriteLine("El nombre del socio es: " + dni);
            }
        }

        public decimal getPrecioMesCuotaSocial()
        {
            return PagoCuotaSocial.PrecioMensual;
        }
    }
}
