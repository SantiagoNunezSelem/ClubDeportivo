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

        //Este constructor es utilizado para recuperar los datos de la base de datos y asignarle el idPago que estaba almacenado
        public PagoActividadDeportiva(int idPago, Socio socio, decimal pagoFinal, DateTime fechaPago, ActividadDeportiva actividadDeportiva)
            : base(idPago, socio, pagoFinal, fechaPago)
        {
            this.actividadDeportiva = actividadDeportiva;
        }

        public ActividadDeportiva ActividadDeportivaInfo
        {
            get { return actividadDeportiva; }
        }

        public bool estaActiva()
        {
            return (DateTime.Today <= this.fechaPago.AddMonths(1));
        }

        //Definir el formato con el que se muestra dentro de un listBox
        public override string ToString()
        {
            return $" Fecha: {fechaPago.ToShortDateString()} , Nombre: {actividadDeportiva.Nombre} , Pago: {pagoFinal}";
        }
    }
}
