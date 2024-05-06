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

        private void inputCantMeses_TextChanged(object sender, EventArgs e)
        {
            int cantMeses;
            if (!int.TryParse(inputCantMeses.Text, out cantMeses))
            {
                cantMeses = 0;
            }

            if (cantMeses > 0)
            {
                decimal precioMes = PagoCuotaSocial.PrecioMensual; //No puedo obtener el valor ;(  (lo demas deveria funcionar)
                inputPrecioFinal.Text = "$" + (cantMeses * precioMes).ToString();
            }
            else
            {
                inputPrecioFinal.Text = "";
            }
        }
    }
}
