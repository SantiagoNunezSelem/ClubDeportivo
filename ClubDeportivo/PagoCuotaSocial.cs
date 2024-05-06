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
        private decimal PRECIOMENSUAL;
        private int MAXACTIVIDADESGRATUITAS;
        private int cantActividadesDeCuotaSocial; //Cant actividades registradas cuando la cuota social esta activa
        private int cantMeses;
        

        public PagoCuotaSocial(Socio socio, decimal pagoFinal, DateTime fechaPago, int cantMeses)
            : base(socio, pagoFinal, fechaPago)
        {
            this.PRECIOMENSUAL = 5000;
            this.MAXACTIVIDADESGRATUITAS = 5;
            this.cantActividadesDeCuotaSocial = 0;
            this.cantMeses = cantMeses;
        }
    }
}
