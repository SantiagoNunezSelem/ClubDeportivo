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
    public partial class Inicio : NavBar
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (base.guardar()) {
                MessageBox.Show("Guardado con éxito", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else { 
                MessageBox.Show("NO GUARDADO", "ALERTA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
