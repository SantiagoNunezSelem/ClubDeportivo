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

        public ActividadDeportiva ActividadDeportivaInfo
        {
            get { return actividadDeportiva; }
        }

        //Definir el formato con el que se muestra dentro de un listBox
        public override string ToString()
        {
            return $" Fecha: {fechaPago.ToShortDateString()} , Nombre: {actividadDeportiva.Nombre} , Pago: {pagoFinal}";
        }
    }
}
