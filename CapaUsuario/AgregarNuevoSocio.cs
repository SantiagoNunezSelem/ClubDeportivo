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
    public partial class AgregarNuevoSocio : CapaUsuario.NavBar
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
            string nombre = inputNombre.Text;
            string apellido = inputApellido.Text;
            string email = inputEmail.Text;
            DateTime fechaNacimiento = DateTime.Parse(inputFechaNacimiento.Text);

            this.socio = new Socio(dni,nombre,apellido,email,fechaNacimiento);

            this.Close();
        }

        public Socio getSocio()
        {
            return this.socio;
        }
    }
}
