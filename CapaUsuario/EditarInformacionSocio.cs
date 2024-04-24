﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class EditarInformacionSocio : CapaUsuario.NavBar
    {
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
    }
}