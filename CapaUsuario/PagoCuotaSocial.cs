using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class PagoCuotaSocial : CapaUsuario.NavBar
    {
        public PagoCuotaSocial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void inputCantMeses_MouseClick(object sender, MouseEventArgs e)
        {
            inputCantMeses.Select(0, 0);
        }
    }
}
