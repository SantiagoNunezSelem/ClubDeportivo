﻿using System;
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
        private string dni; //HOLA 
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private DateTime fechaNacimiento;

        public Socio(string dni, string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
        }

        public bool esDni(string dni)
        {
            return dni.Equals(this.dni);
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

        public string getDni()
        {
            return this.dni;
        }
    }
}
