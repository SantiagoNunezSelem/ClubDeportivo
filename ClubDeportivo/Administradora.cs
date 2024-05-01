using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class Administradora
    {
        private static Administradora instancia;
        private List<Socio> socios;
        private Administradora()
        {
            socios = new List<Socio>();
        }

        public static Administradora ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Administradora();
            }
            return instancia;
        }

        public Socio buscarSocio(string dni)
        {
            Socio socioEncontrado = socios.Find(socio => socio.Dni == dni);
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
                string dni = socio.Dni;
                Console.WriteLine("El nombre del socio es: " + dni);
            }
        }
    }
}
