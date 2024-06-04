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
    public partial class InformacionActividadDeportiva : AdministradoraForm
    {
        public InformacionActividadDeportiva()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void selectActividadDeportiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreActividadDeportiva = selectActividadDeportiva.Text;
            ActividadDeportiva actividadSeleccionada = base.buscarActividadDeportiva(nombreActividadDeportiva);

            if (actividadSeleccionada != null)
            {
                labelPrecioPorMes.Text = "$" + actividadSeleccionada.PrecioMes.ToString(); //Precio del mes sin ningun descuento de Cuota Social
                labelVacantes.Text = actividadSeleccionada.getVacantes().ToString();
                labelAluInscriptos.Text = actividadSeleccionada.CantAlumnosInscriptos.ToString();
                labelHorario.Text = actividadSeleccionada.Horario;
            }
            else
            {
                labelPrecioPorMes.Text = "         -         ";
                labelVacantes.Text = "         -         ";
                labelAluInscriptos.Text = "         -         ";
                labelHorario.Text = "         -         ";
            }
        }
    
    }
}
