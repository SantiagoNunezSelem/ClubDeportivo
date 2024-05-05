using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        private int idPago;
        private Socio socio;
        private decimal monto;
        private DateTime fechaPago;


        public Pago(int idPago, Socio socio, decimal monto, DateTime fechaPago)
        {
            this.idPago = idPago;
            this.socio = socio;
            this.monto = monto;
            this.fechaPago = fechaPago;
        }

        public int IDPago
        {
            get { return idPago; }
            set { idPago = value; }
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

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
