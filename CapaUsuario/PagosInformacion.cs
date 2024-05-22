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
    public partial class PagosInformacion : AdministradoraForm
    {
        public PagosInformacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                if (socio.tieneCuotaSocialActiva())
                {
                    labelEstadoCuotaSocial.Text = "Activa";
                }
                else
                {
                    labelEstadoCuotaSocial.Text = "Inactiva";
                }
                 
            }
        }

        private void selectTipoPago_TextChanged(object sender, EventArgs e)
        {
            listBoxPagos.Items.Clear();

            string dniBuscar = inputDniBuscar.Text;
            Socio socio = base.existeSocio(dniBuscar);
            if (socio != null)
            {
                int indexTipoPago = selectTipoPago.SelectedIndex; //0 = pagos cuotas sociales; 1 = pagos actividades deportivas
                if (indexTipoPago == 0)
                {
                    List <PagoCuotaSocial> pagosCuotaSocial = socio.getPagosCuotaSocial();

                    foreach(PagoCuotaSocial pago in pagosCuotaSocial)
                    {
                        listBoxPagos.Items.Add(pago);
                    }
                }
                else
                {
                    if (indexTipoPago == 1)
                    {
                        List<PagoActividadDeportiva> pagosActividadDeportiva = socio.getPagosActividadDeportiva();

                        foreach (PagoActividadDeportiva pago in pagosActividadDeportiva)
                        {
                            listBoxPagos.Items.Add(pago);
                        }
                    }
                    else
                    {
                        listBoxPagos.Items.Add("No hay información disponible");
                    }
                }
            }


            
            
        }
    }
}
