﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class InformacionSocio : CapaUsuario.NavBar
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
    }
}