using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class ActividadDeportiva
    {
        string nombreProfesor;
        string horario;
        int cantAlumnosMax;
        decimal precioMes;
        private List<Socio> alumnosInscriptos;

        public ActividadDeportiva(string nombreProfesor, string horario, int cantAlumnosMax, decimal precioMes)
        {
            this.nombreProfesor = nombreProfesor;
            this.horario = horario;
            this.cantAlumnosMax = cantAlumnosMax;
            this.precioMes = precioMes;
            alumnosInscriptos = new List<Socio>();
        }
    }
}
