using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoActividadDeportiva : Pago
    {
        private ActividadDeportiva actividadDeportiva;

        public PagoActividadDeportiva(Socio socio, decimal pagoFinal, DateTime fechaPago, ActividadDeportiva actividadDeportiva)
            : base(socio, pagoFinal, fechaPago)
        {
            this.actividadDeportiva = actividadDeportiva;
        }
    }
}
