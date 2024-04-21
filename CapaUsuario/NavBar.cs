﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class NavBar : Form
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private void agregarUnNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarNuevoSocio agregarNuevoSocio = new AgregarNuevoSocio();
            agregarNuevoSocio.Show();
            this.Hide();
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
    }
}
