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
    public partial class PagoCuotaSocialForm : AdministradoraForm
    {
        public PagoCuotaSocialForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void PagoCuotaSocial_Load(object sender, EventArgs e)
        {
            inputPrecioMes.Text = base.getPrecioMesCuotaSocial().ToString();
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
                decimal precioMes = base.getPrecioMesCuotaSocial();
                inputPrecioFinal.Text = "$" + (cantMeses * precioMes).ToString();
            }
            else
            {
                inputPrecioFinal.Text = "";
            }
        }

        private void buscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = inputDniBuscar.Text;
            Socio socio = base.existeSocio(dniBuscar);
            if (socio == null)
            {
                MessageBox.Show("Persona no registrada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelNombre.Text = socio.Nombre;
                labelApellido.Text = socio.Apellido;
            }
        }

        private void guardarPagoCuotaSocial_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = inputDniBuscar.Text;
            Socio socio = base.existeSocio(dniBuscar);
            if (socio != null)
            {
                int cantMeses;
                if (!int.TryParse(inputCantMeses.Text, out cantMeses))
                {
                    cantMeses = 0;
                }

                if (cantMeses > 0)
                {
                    DateTime fechaPago; //Es la fecha desde la cual inicia el pago de la cuota social (se puede pagar por adelantado)
                    if (socio.tieneCuotaSocialActiva())
                    {
                        //Buscar cual es la ultima cuota social activa y obtener la fecha. Luego sumarle 1 mes a dicha fecha
                        fechaPago = (socio.getUltimaFechaCuotaSocialSocio()).AddMonths(1);
                    }
                    else
                    {
                        fechaPago = DateTime.Now;
                    }

                    decimal precioMes = getPrecioMesCuotaSocial();

                    //Se crea un objeto PagoCuotaSocial por cada mes que haya pagado
                    for(int i=0; i < cantMeses; i++)
                    {
                        PagoCuotaSocial pagoCS = new PagoCuotaSocial(socio, precioMes, fechaPago.AddMonths(i));
                        base.agregarPagoCuotaSocial(pagoCS);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione cantidad de meses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Persona no registrada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
