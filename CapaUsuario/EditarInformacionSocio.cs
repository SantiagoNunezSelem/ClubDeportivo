using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class EditarInformacionSocio : Administradora
    {
        private Socio socio;
     
        public EditarInformacionSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BotonBuscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            InputBuscarDni.Select(0, 0);
        }

        private void InputBuscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            InputBuscarDni.Select(0, 0);
        }

        private void searchByDni_MouseClick(object _, MouseEventArgs __) {
            string dni = this.InputBuscarDni.Text;

            Socio socio = base.existeSocio(dni);

            if (socio != null) {
                this.inputApellido.Text = socio.Apellido;
                this.inputEmail.Text = socio.Email;
                this.inputFechaNacimiento.Text = socio.FechaNacimiento.ToString("dd / MM / yyyy");
                this.inputNombre.Text = socio.Nombre;
                this.inputTelefono.Text = socio.Telefono;
            } else {
                MessageBox.Show("Persona no registrada. Revise el DNI", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputApellido.Text = "";
            }
        }

        private void saveNewSocio_MouseClick(object sender, MouseEventArgs e) {
            string dni = this.InputBuscarDni.Text;
            Socio socio = base.existeSocio(dni);

            if (socio != null) {
                socio.Nombre = this.inputNombre.Text;
                socio.Apellido = this.inputApellido.Text;
                socio.Email = this.inputEmail.Text;
                socio.Telefono = this.inputTelefono.Text;
                socio.FechaNacimiento = DateTime.Parse(this.inputFechaNacimiento.Text);

                MessageBox.Show("¡Socio actualizado con éxito!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public void inputFechaNacimiento_MaskInputRejected() {

        }

    }
}
