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
        
        public PagoCuotaSocial(Socio socio, decimal pagoFinal, DateTime fechaPago)
            : base(socio, pagoFinal, fechaPago)
        {
            this.cantActividadesDeCuotaSocial = 0;
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
    }
}
