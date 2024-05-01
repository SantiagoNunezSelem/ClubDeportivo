using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private DateTime fechaNacimiento;

        public Socio(string dni, string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        public bool esDni(string dni)
        {
            return dni.Equals(this.dni);
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getDni()
        {
            return this.dni;
        }
    }
}
