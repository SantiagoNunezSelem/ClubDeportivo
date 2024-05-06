using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ActividadDeportiva
    {
        string nombreActividad;
        string nombreProfesor;
        string horario;
        int cantAlumnosMax;
        decimal precioMes;
        private List<Socio> alumnosInscriptos;

        public ActividadDeportiva(string nombreActividad, string nombreProfesor, string horario, int cantAlumnosMax, decimal precioMes)
        {
            this.nombreActividad = nombreActividad;
            this.nombreProfesor = nombreProfesor;
            this.horario = horario;
            this.cantAlumnosMax = cantAlumnosMax;
            this.precioMes = precioMes;
            alumnosInscriptos = new List<Socio>();
        }

        public string Nombre
        {
            get { return nombreActividad; }
            set { this.nombreActividad = value; }
        }

        public decimal PrecioMes
        {
            get { return precioMes; }
            set { this.precioMes = value; }
        }
    }
}
