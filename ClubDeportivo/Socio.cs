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

        public PagoCuotaSocial buscarCuotaSocialActualActiva()
        {
            //1)Revisa el ultimo pago de cuota social y retorna si está activo
            //2)Como se pueden pagar varios meses de una vez, tenemos que recorrer el array
            //  del final al inicio hasta que alguna mes no este activo y retornar el anterior (el que esta activo)
            //3)En caso de que ningun pago membresía siga activo, retornamos null

            if (pagosCuotaSocial.Count > 0)
            {
                int i = pagosCuotaSocial.Count - 1;

                PagoCuotaSocial buscarPagoCuotaSocial = null;
                PagoCuotaSocial pagoCuotaSocialActiva = null;
                
                while (i >= 0)
                {
                    buscarPagoCuotaSocial = pagosCuotaSocial[i];
                    if (buscarPagoCuotaSocial.estaActiva())
                    {
                        pagoCuotaSocialActiva = buscarPagoCuotaSocial; //Guardo la ultima cuotaSocial que encontré activa
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if(i == 0)
                {
                    return buscarPagoCuotaSocial; //El primer pago realizado de la Cuota Social está activo
                }

                if (i != pagosCuotaSocial.Count)
                {
                    return pagoCuotaSocialActiva;
                }
            }
            return null;
        }

        public bool tieneCuotaSocialActiva()
        {
            if (pagosCuotaSocial.Count > 0)
            {
                PagoCuotaSocial ultimoPagoCuotaSocial = pagosCuotaSocial[pagosCuotaSocial.Count - 1]; //no reviso cual es la ultima activa, no hace falta. Miro unicamente la ultima que pagó y me fijo si esta activa
                return ultimoPagoCuotaSocial.estaActiva();
            }
            return false;
        }

        public void agregarActividadAsociadaCuotaSocial()
        {
            //Debo agregarla a la cuota social activa de este mes
            PagoCuotaSocial pagoCS = this.buscarCuotaSocialActualActiva();

            if (pagoCS != null)
            {
                pagoCS.agregarActividadAsociada();
            }
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad)
        {
            pagosActividadDeportiva.Add(pagoActividad); //Se guarda en el array general

            if (this.tieneCuotaSocialActiva())
            {
                this.agregarActividadAsociadaCuotaSocial(); //Si tiene cuota social activa se agrega +1 a la cantidad de actividades deportivas asociada a dicha cuota social
            }
        }

        public void agregarPagoCuotaSocial(PagoCuotaSocial pagoCS)
        {
            pagosCuotaSocial.Add(pagoCS);
        }

        public List<PagoCuotaSocial> getPagosCuotaSocial()
        {
            return pagosCuotaSocial;
        }

        public List<PagoActividadDeportiva> getPagosActividadDeportiva()
        {
            return pagosActividadDeportiva;
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
