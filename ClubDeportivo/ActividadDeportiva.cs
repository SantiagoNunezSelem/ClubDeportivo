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
        private int cantAlumnosInscriptos;

        public ActividadDeportiva(string nombreActividad, string nombreProfesor, string horario, int cantAlumnosMax, decimal precioMes)
        {
            this.nombreActividad = nombreActividad;
            this.nombreProfesor = nombreProfesor;
            this.horario = horario;
            this.cantAlumnosMax = cantAlumnosMax;
            this.precioMes = precioMes;
            this.cantAlumnosInscriptos = 0;
        }

        public ActividadDeportiva(string nombreActividad, string nombreProfesor, string horario, int cantAlumnosMax,int cantAluInscriptos, decimal precioMes)
        {
            this.nombreActividad = nombreActividad;
            this.nombreProfesor = nombreProfesor;
            this.horario = horario;
            this.cantAlumnosMax = cantAlumnosMax;
            this.precioMes = precioMes;
            cantAlumnosInscriptos = cantAluInscriptos;
        }

        public int getVacantes()
        {
            return (cantAlumnosMax - cantAlumnosInscriptos);
        }

        public void agregarAlumno()
        {
            this.cantAlumnosInscriptos++;
        }


        public string Nombre
        {
            get { return nombreActividad; }
            set { this.nombreActividad = value; }
        }

        public string NombreProfesor
        {
            get { return this.nombreProfesor; }
            set { this.nombreProfesor = value; }
        }

        public decimal PrecioMes
        {
            get { return precioMes; }
            set { this.precioMes = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { this.horario = value; }
        }

        public int AlumnosInscriptos
        {
            get { return cantAlumnosInscriptos; }
        }
    }
}
