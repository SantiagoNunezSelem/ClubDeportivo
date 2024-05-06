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
    public partial class PagoActividadDeportiva : CapaUsuario.NavBar
    {
        private ActividadDeportiva actividadSeleccionada;
        public PagoActividadDeportiva()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            actividadSeleccionada = null;
        }

        private void botonBuscarDni_MouseClick(object sender, MouseEventArgs e)
        {
            string dniBuscar = inputDniBuscar.Text;
            Socio buscarSocio = base.existeSocio(dniBuscar);
            if (buscarSocio != null)
            {
                inputNombre.Text = buscarSocio.Nombre;
                inputApellido.Text = buscarSocio.Apellido;
            }
            else
            {
                MessageBox.Show("Persona no registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarPagoActividadDeportiva_MouseClick(object sender, MouseEventArgs e)
        {
            string dni = inputDniBuscar.Text;
            Socio buscarSocio = base.existeSocio(dni);

            if (buscarSocio != null)
            {
                if (actividadSeleccionada != null)
                {
                    MessageBox.Show("Actividad seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Actividad no seleccionada pa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La persona no está registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selecActividadDeportiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreActividadDeportiva = selecActividadDeportiva.Text;
            actividadSeleccionada = base.buscarActividadDeportiva(nombreActividadDeportiva);

            if (actividadSeleccionada != null)
            {
                inputPrecioMes.Text = "$" + actividadSeleccionada.PrecioMes.ToString();
            }
            else
            {
                inputPrecioMes.Text = "         -         ";
            }
        }

        private void inputCantMeses_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            // NO FUNCIONA, VER DESPUES
            int cantMeses = int.Parse(inputCantMeses.Text);
            MessageBox.Show("La persona no está registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cantMeses > 0 && actividadSeleccionada != null)
            {
                decimal precioMes = actividadSeleccionada.PrecioMes;
                inputPrecioFinal.Text = (cantMeses * precioMes).ToString();
            }
            else
            {
                inputPrecioFinal.Text = "";
            }
        }

        private void inputCantMeses_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
