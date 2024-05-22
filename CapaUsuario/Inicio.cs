using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaUsuario
{
    public partial class Inicio : AdministradoraForm
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void agregarUnNuevoSocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarNuevoSocio agregarSocio = new AgregarNuevoSocio();
            agregarSocio.ShowDialog();
            base.agregarSocio(agregarSocio);
        }

        private void informaciónSocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InformacionSocio informacionSocio = new InformacionSocio();
            informacionSocio.ShowDialog();
        }

        private void editarInformaciónSocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditarInformacionSocio editarInformacionSocio = new EditarInformacionSocio();
            editarInformacionSocio.ShowDialog();
        }

        private void darDeBajaSocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DarBajaSocio darBajaSocio = new DarBajaSocio();
            darBajaSocio.ShowDialog();
        }

        private void pagoDeCuoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PagoCuotaSocialForm pagoCuotaSocial = new PagoCuotaSocialForm();
            pagoCuotaSocial.ShowDialog();
        }

        private void pagoDeActividadDeportivaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PagoActividadDeportivaForm pagoActividadDeportiva = new PagoActividadDeportivaForm();
            pagoActividadDeportiva.ShowDialog();

        }

        private void informaciónPagosDeSocioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PagosInformacion pagosInformacion = new PagosInformacion();
            pagosInformacion.ShowDialog();
        }

        private void informaciónDeActividadDeportivaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InformacionActividadDeportiva infoACtividadDeportiva = new InformacionActividadDeportiva();
            infoACtividadDeportiva.ShowDialog();
        }
    }
}
