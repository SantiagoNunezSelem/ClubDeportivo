using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class NavBar : Form
    {
        private Administradora adm = Administradora.ObtenerInstancia();
        public NavBar()
        {
            InitializeComponent();
        }

        private void agregarUnNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarNuevoSocio agregarSocio = new AgregarNuevoSocio();
            this.agregarSocio(agregarSocio);
        }

        public void agregarSocio(AgregarNuevoSocio agregarSocio)
        {
            this.Hide();
            agregarSocio.ShowDialog();
            this.Show();

            Socio socio = agregarSocio.getSocio();
            if(socio != null ) 
            {
                adm.agregarSocio(socio);
            }
        }

        public void eliminarSocio(string dni)
        {
            adm.eliminarSocio(dni);
        }

        public Socio existeSocio(string dni){
            Socio socio = adm.buscarSocio(dni);
            return socio;
        }

        public ActividadDeportiva buscarActividadDeportiva(string nombre)
        {
            return adm.buscarActividadDeportiva(nombre);
        }

        public void agregarPagoActividadDeportiva(PagoActividadDeportiva pagoActividad)
        {
            adm.agregarPagoActividadDeportiva(pagoActividad);
        }

        public decimal getPrecioMesCuotaSocial()
        {
            return adm.getPrecioMesCuotaSocial();
        }

        public void agregarPagoCuotaSocial(PagoCuotaSocial pagoCS)
        {
            adm.agregarPagoCuotaSocial(pagoCS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void informaciónSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionSocio informacionSocio = new InformacionSocio();
            informacionSocio.Show();
            this.Hide();
        }

        private void editarInformaciónSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarInformacionSocio editarInformacionSocio = new EditarInformacionSocio();
            this.Hide();
            editarInformacionSocio.ShowDialog();
            this.Show();
        }

        private void darDeBajaSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarBajaSocio darBajaSocio = new DarBajaSocio();
            this.Hide();
            darBajaSocio.ShowDialog();
            this.Show();
        }

        private void pagoDeCuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoCuotaSocialForm pagoCuotaSocial = new PagoCuotaSocialForm();
            this.Hide();
            pagoCuotaSocial.ShowDialog();
            this.Show();
        }

        private void pagoDeActividadDeportivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoActividadDeportivaForm pagoActividadDeportiva = new PagoActividadDeportivaForm();
            this.Hide();
            pagoActividadDeportiva.ShowDialog();
            this.Show();
        }

        private void informaciónPagosDeSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagosInformacion pagosInformacion = new PagosInformacion();
            pagosInformacion.Show();
            this.Hide();
        }

        private void informaciónDeActividadDeportivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionActividadDeportiva infoACtividadDeportiva = new InformacionActividadDeportiva();
            infoACtividadDeportiva.Show();
            this.Hide();
        }
    }
}
