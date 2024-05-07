using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Socio
    {
        private string dni;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private DateTime fechaNacimiento;
        private List<PagoCuotaSocial> pagosCuotaSocial;
        private List<PagoActividadDeportiva> pagosActividadDeportiva;

        public Socio(string dni, string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            pagosCuotaSocial = new List<PagoCuotaSocial>();
            pagosActividadDeportiva = new List<PagoActividadDeportiva>();
        }

        public bool cuotaSocialActiva()
        {
            //Revisa el ultimo pago de cuota social y retorna si está activo
            if (pagosCuotaSocial.Count > 0)
            {
                PagoCuotaSocial ultimoPagoCuotaSocial = pagosCuotaSocial[pagosCuotaSocial.Count - 1];
            }
            return false; //luego hacerlo, por ahora nunca tiene membresia activa
        }

        public void agregarActividadAsociadaCuotaSocial()
        {
            if (pagosCuotaSocial.Count > 0)
            {
                PagoCuotaSocial ultimoPagoCuotaSocial = pagosCuotaSocial[pagosCuotaSocial.Count - 1];
                ultimoPagoCuotaSocial.agregarActividadAsociada();
            }
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad)
        {
            pagosActividadDeportiva.Add(pagoActividad);

            if (this.cuotaSocialActiva())
            {
                this.agregarActividadAsociadaCuotaSocial();
            }
        }

        public void agregarPagoCuotaSocial(PagoCuotaSocial pagoCS)
        {
            pagosCuotaSocial.Add(pagoCS);
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
    }
}
