using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CapaUsuario
{
    public partial class AgregarNuevoSocio : AdministradoraForm
    {
        private Socio socio;

        public AgregarNuevoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MaskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            inputDni.Select(0, 0);
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            inputNombre.Select(0, 0);
        }

        private void inputApellido_MouseClick(object sender, MouseEventArgs e)
        {
            inputApellido.Select(0, 0);
        }

        private void inputFechaNacimiento_MouseClick(object sender, MouseEventArgs e)
        {
            inputFechaNacimiento.Select(0, 0);
        }

        private void inputTelefono_MouseClick(object sender, MouseEventArgs e)
        {
            inputTelefono.Select(0, 0);
        }

        private void inputEmail_MouseClick(object sender, MouseEventArgs e)
        {
            inputEmail.Select(0, 0);
        }

        private void registrarUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            string dni = inputDni.Text;
            
            Socio buscarSocio = base.existeSocio(dni);

            if (buscarSocio == null)
            {
                string nombre = inputNombre.Text;
                string apellido = inputApellido.Text;
                string email = inputEmail.Text;
                string telefono = inputTelefono.Text;
                DateTime fechaNacimiento = DateTime.Parse(inputFechaNacimiento.Text);
                this.socio = new Socio(dni, nombre, apellido, email, telefono, fechaNacimiento);
                
                Close();
            }
            else
            {
                MessageBox.Show("El socio ya está registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Socio getSocio()
        {
            return this.socio;
        }

        private void buscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = inputDni.Text;
            Socio buscarSocio = base.existeSocio(dniBuscar);
            if (buscarSocio != null)
            {
                MessageBox.Show("El socio ya está registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Persona no registrada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
