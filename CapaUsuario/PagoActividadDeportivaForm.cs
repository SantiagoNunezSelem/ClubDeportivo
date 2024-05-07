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
    public partial class PagoActividadDeportivaForm : CapaUsuario.NavBar
    {
        private ActividadDeportiva actividadSeleccionada;
        public PagoActividadDeportivaForm()
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
                    if(actividadSeleccionada.getVacantes() > 0)
                    {
                        decimal pagoFinal = actividadSeleccionada.PrecioMes;
                        DateTime fecha = DateTime.Now;
                        PagoActividadDeportiva pagoActividad = new PagoActividadDeportiva(buscarSocio, pagoFinal, fecha, actividadSeleccionada);
                        base.agregarPagoActividadDeportiva(pagoActividad);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay vacantes para la actividad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Actividad no seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La persona no está registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selecActividadDeportiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreActividadDeportiva = selecActividadDeportiva.Text;
            actividadSeleccionada = base.buscarActividadDeportiva(nombreActividadDeportiva);

            if (actividadSeleccionada != null)
            {
                inputPrecioMes.Text = "$" + actividadSeleccionada.PrecioMes.ToString();
                inputCantVacantes.Text = actividadSeleccionada.getVacantes().ToString();
                inputHorarios.Text = actividadSeleccionada.Horario;
            }
            else
            {
                inputPrecioMes.Text = "         -         ";
                inputCantVacantes.Text = "         -         ";
                inputHorarios.Text = "         -         ";
            }
        }
    }
}
