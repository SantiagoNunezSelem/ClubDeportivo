using CapaDatos;
using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7 {
    public partial class Contact: Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                string idSocio = (Session["id"] as string);

                List<string> actividadesDisponibles = Administradora.obtenerIDdeActividadesDisponiblesPara(idSocio);
                ddlDeportes.Items.Add(new ListItem("Seleccione un deporte", ""));

                for (int i = 0; i < actividadesDisponibles.Count; i++) {
                    if (actividadesDisponibles[i] == "1")
                        ddlDeportes.Items.Add(new ListItem("Natación", "1"));
                    else if(actividadesDisponibles[i] == "2")
                        ddlDeportes.Items.Add(new ListItem("Voley", "2"));
                    else if(actividadesDisponibles[i] == "3")
                        ddlDeportes.Items.Add(new ListItem("Fútbol", "3"));
                }
            }
        }

        protected void inscripcionDeActividad(object sender, EventArgs e) {
            // Obtener el valor seleccionado
            string idActividad = ddlDeportes.SelectedValue;
            string nombreActividad = ddlDeportes.SelectedItem.Text;
            
            string idSocio = (Session["id"] as string);

            Administradora.inscripcionEnActividad(idSocio, idActividad);

            ddlDeportes.Items.Remove(new ListItem(nombreActividad, idActividad));
            success.Text = "Felicidades, ahora se encuentra inscripto en la actividad seleccionada. Recuerde pagar la cuota correspondiente.";
            ddlDeportes.SelectedIndex = 0;
        }
    }
}