using System;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	class SActividadDeportiva: Socio //herencia de socio
	{

        public SActividadDeportiva()
                 : base(string dni, string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento)
        {
        }


    }
}
