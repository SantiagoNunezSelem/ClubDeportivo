using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoCuotaSocial : Pago
    {
        private static decimal PrecioMensualData = 30000;
        private static int MaxActividadesGratuitas = 5;
        private int cantActividadesDeCuotaSocial; //Cant actividades registradas cuando la cuota social esta activa
        private DateTime fechaInicio; //Fecha de inicio de la ultima cuota social activa
        private int cantidadCuotasPagas;
        
        public PagoCuotaSocial(Socio socio, decimal pagoFinal, DateTime fechaPago, DateTime fechaInicio, int cantidadCuotasPagas)
            : base(socio, pagoFinal, fechaPago)
        {
            this.cantActividadesDeCuotaSocial = 0;
            this.cantidadCuotasPagas = cantidadCuotasPagas;
        }

        public void agregarActividadAsociada()
        {
            this.cantActividadesDeCuotaSocial++;
        }

        public bool estaActiva()
        {
            return (DateTime.Today <= this.fechaPago.AddMonths(1));
        }

        public static decimal PrecioMensual
        {
            get { return PrecioMensualData; }
        }

        public int getCantActividadesDeCuotaSocial()
        {
            return cantActividadesDeCuotaSocial;
        }

        //Definir el formato con el que se muestra dentro de un listBox
        public override string ToString()
        {
            string estado;
            if (this.estaActiva())
            {
                estado = "Activa";
            }
            else
            {
                estado = "Inactiva";
            }
            return $" Fecha: {fechaPago.ToShortDateString()} , Pago: {pagoFinal} , Estado: {estado}";
        }

        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }

        public void setFechaInicio(DateTime fe)
        {
            fechaInicio=fe;
        }

        public int CantCuotasPagas
        {
            get { return cantidadCuotasPagas; }
            set { this.cantidadCuotasPagas = value; }
        }

    }
}
