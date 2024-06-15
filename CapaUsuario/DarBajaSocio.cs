using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class DarBajaSocio : CapaUsuario.InformacionSocio
    {
        public DarBajaSocio()
        {
            InitializeComponent();
        }

        private void botonEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = InputBuscarDni.Text;
            Socio buscarSocio = base.existeSocio(dniBuscar);
            if (buscarSocio != null)
            {
                base.eliminarSocio(dniBuscar);
                this.Close();
            }
            else
            {
                MessageBox.Show("Persona no registrada LOKO", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputBuscarDni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
