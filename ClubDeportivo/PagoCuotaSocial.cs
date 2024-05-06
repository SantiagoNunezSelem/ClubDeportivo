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
        private int cantMeses;
        

        public PagoCuotaSocial(Socio socio, decimal pagoFinal, DateTime fechaPago, int cantMeses)
            : base(socio, pagoFinal, fechaPago)
        {
            this.cantActividadesDeCuotaSocial = 0;
            this.cantMeses = cantMeses;
        }

        public void agregarActividadAsociada()
        {
            this.cantActividadesDeCuotaSocial++;
        }

        public static decimal PrecioMensual
        {
            get { return PrecioMensualData; }
        }
    }
}
