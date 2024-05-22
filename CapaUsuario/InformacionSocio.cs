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
    public partial class InformacionSocio : AdministradoraForm
    {
        public InformacionSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InputBuscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            InputBuscarDni.Select(0, 0);
        }

        private void buscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = InputBuscarDni.Text;
            Socio socio = base.existeSocio(dniBuscar);
            if(socio == null)
            {
                MessageBox.Show("Persona no registrada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fechaNacimientoSocio = socio.FechaNacimiento.ToString("dd / MM / yyyy");

                labelNombre.Text = socio.Nombre;
                labelApellido.Text = socio.Apellido;
                labelFechaNacimiento.Text = fechaNacimientoSocio;
                labelEmail.Text = socio.Email;
                labelTelefono.Text = socio.Telefono;

            }
        }
    }
}
