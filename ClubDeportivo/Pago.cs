using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        static int counterID = int.Parse(Datos.getIdUltimoPagoRegistrado());

        protected int idPago;
        protected Socio socio;
        protected decimal pagoFinal;
        protected DateTime fechaPago;

        public Pago(Socio socio, decimal pagoFinal, DateTime fechaPago)
        {
            this.socio = socio;
            this.pagoFinal = pagoFinal;
            this.fechaPago = fechaPago;
            this.idPago = getIDPagoUnico();
        }

        //Este constructor es utilizado para recuperar los datos de la base de datos y asignarle el idPago que estaba almacenado
        public Pago(int idPago, Socio socio, decimal pagoFinal, DateTime fechaPago)
        {
            this.socio = socio;
            this.pagoFinal = pagoFinal;
            this.fechaPago = fechaPago;
            this.idPago = idPago;
        }

        public int getIDPagoUnico()
        {
            counterID++;
            return counterID;
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

        public int IdPago
        {
            get { return idPago; }
        }

    }
}
