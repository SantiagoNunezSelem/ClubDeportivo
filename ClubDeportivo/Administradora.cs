using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]

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

        public static Administradora ObtenerInstancia() {
            Administradora instanciaRecuperada = (Administradora) Datos.Recuperar();

            if(instanciaRecuperada != null)
                instancia = instanciaRecuperada;
            else if (instancia == null) {
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

            //Agregar el Socio a la actividad deportiva
            actividadDep.agregarAlumno(socioDeActividad);
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


        public bool guardar() {
            return Datos.Guardar(this);
        }
    }
}
