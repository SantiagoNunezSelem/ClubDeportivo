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
        public AgregarNuevoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MaskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.Select(0, 0);
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

        private void AgregarNuevoSocio_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
