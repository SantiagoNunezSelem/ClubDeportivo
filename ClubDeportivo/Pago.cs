using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class Pago
    {
        protected Socio socio;
        protected decimal pagoFinal;
        protected DateTime fechaPago;

        public Pago(Socio socio, decimal pagoFinal, DateTime fechaPago)
        {
            this.socio = socio;
            this.pagoFinal = pagoFinal;
            this.fechaPago = fechaPago;
        }

        public Socio Socio
        {
            get { return socio; }
            set { socio = value; }
        }

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }

        public decimal PagoFinal
        {
            get { return pagoFinal; }
            set { pagoFinal = value; }
        }

    }
}
