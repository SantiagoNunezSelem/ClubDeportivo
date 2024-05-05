using System;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class SClub : Socio //herencia de socio
    {
        private decimal cuotaSocial;
        private static int cantActDeportivaSinCosto = 5; //hasta 5 actividades sin costo
        private static decimal descuentoActExtra = 1.5; //50% descuento en cada act extra

        public SClub(decimal cuotaS, int cantActSinCosto, decimal descActExtra)
                 : base(string dni, string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento)
        {
            cuotaSocial = cuotaS;
            cantActDeportivaSinCosto = cantActSinCosto;
            descuentoActExtra = descActExtra;
        }

    }
}
