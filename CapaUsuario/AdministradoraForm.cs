using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class AdministradoraForm : Form
    {
        private CapaNegocio.Administradora adm = CapaNegocio.Administradora.ObtenerInstancia();
        public AdministradoraForm()
        {
            InitializeComponent();
            adm.setConnectionDBPath(Application.StartupPath);

            string errorMessage = null;    //si hay un error lo guarda

            if (!adm.getActividadesDeportivas(ref errorMessage))
            {
                MessageBox.Show("Error en base de datos -> metodo getActividadesDeportivas \n" + errorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!adm.getSocios(ref errorMessage))
            {
                MessageBox.Show("Error en base de datos -> metodo getSocios \n" + errorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void agregarSocio(AgregarNuevoSocio agregarSocio)
        {
            Socio socio = agregarSocio.getSocio();
            if (socio != null)
            {
                adm.agregarSocio(socio);
                adm.guardarNuevoSocioDB(socio);
            }
        }
        public void eliminarSocio(string dni)
        {
            adm.eliminarSocio(dni);
        }

        public Socio existeSocio(string dni)
        {
            Socio socio = adm.buscarSocio(dni);
            return socio;
        }

        public ActividadDeportiva buscarActividadDeportiva(string nombre)
        {
            return adm.buscarActividadDeportiva(nombre);
        }

        public decimal getPrecioActividadDeportiva(Socio socio, ActividadDeportiva actDep)
        {
            return adm.getPrecioActividadDeportiva(socio, actDep);
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad) 
        {
            adm.agregarPagoActividadDeportiva(pagoActividad);
            adm.guardarPagoActividadDeportivaSocioDB(pagoActividad);
        }

        public decimal getPrecioMesCuotaSocial()
        {
            return adm.getPrecioMesCuotaSocial();
        }

        public void agregarPagoCuotaSocial(PagoCuotaSocial pagoCS)
        {
            adm.agregarPagoCuotaSocial(pagoCS);
            adm.guardarPagoCuotaSocialDB(pagoCS);
        }
    }
}
