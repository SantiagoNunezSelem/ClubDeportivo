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

        private void agregarSocio(AgregarNuevoSocio agregarSocio)
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

        public Socio existeSocio(string dni)
        {
            Socio socio = adm.buscarSocio(dni);
            return socio;
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
            editarInformacionSocio.Show();
            this.Hide();
        }

        private void darDeBajaSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarBajaSocio darBajaSocio = new DarBajaSocio();
            darBajaSocio.Show();
            this.Hide();
        }

        private void pagoDeCuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoCuotaSocial pagoCuotaSocial = new PagoCuotaSocial();
            pagoCuotaSocial.Show();
            this.Hide();
        }

        private void pagoDeActividadDeportivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoActividadDeportiva pagoActividadDeportiva = new PagoActividadDeportiva();
            pagoActividadDeportiva.Show();
            this.Hide();
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
