using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class Administradora
    {
        private List<Socio> socios;
        public Administradora()
        {
            socios = new List<Socio>();
        }

        public Socio buscarSocio(string dni)
        {
            Socio socioEncontrado = socios.Find(socio => socio.esDni(dni));
            return socioEncontrado;
        }

        public void agregarSocio(Socio socio) 
        {
            socios.Add(socio);
        }

        public void mostrarSocios()
        {
            foreach(Socio socio in socios)
            {
                string nom = socio.getNombre();
                Console.WriteLine("El nombre del socio es: " + nom);
            }
        }
    }
}
