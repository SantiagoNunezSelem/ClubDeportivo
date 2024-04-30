using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class SocioGeneral
    {
        private string dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        public SocioGeneral(string dni, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
