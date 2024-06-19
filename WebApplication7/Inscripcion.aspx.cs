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
using static WebApplication7.About;

namespace WebApplication7 {
    public partial class Contact: Page {
        Administradora adm;

        protected void Page_Load(object sender, EventArgs e) {
            this.adm = (Session["adm"] as Administradora);

            if (adm == null)
                Response.Redirect("Default.aspx");

            if (!IsPostBack) {
                string idSocio = (Session["id"] as string);
                string errorMessage = null;
                string dni = Session["dni"] as string;

                adm.getSociosDB(ref errorMessage);

                Socio socio = adm.buscarSocio(dni);

                List<PagoActividadDeportiva> pagosAct = socio.getPagosActividadDeportiva();
                List<ActividadDeportiva> actsActivas = new List<ActividadDeportiva>();

                List<ActividadDeportiva> allActs = adm.getActividadesDeportivas();

                pagosAct.ForEach(p => {
                    ActividadDeportiva tmpAct = p.ActividadDeportivaInfo;

                    if (socio.tieneActividadDeportivaActiva(tmpAct)) {
                        allActs.Remove(tmpAct);
                    }
                });

                ddlDeportes.Items.Add(new ListItem("Seleccione un deporte", ""));

                allActs.ForEach(act => {
                    string label = act.Nombre + " " + act.PrecioMes;
                    ListItem dropdownItem = new ListItem(label, act.Nombre);

                    ddlDeportes.Items.Add(dropdownItem);
                });
            }
        }

        protected void inscripcionDeActividad(object sender, EventArgs e) {
            // Obtener el valor seleccionado
            string idActividad = ddlDeportes.SelectedValue;
            string nombreActividad = ddlDeportes.SelectedItem.Text;

            if (idActividad == "") {
                success.Text = "Por favor, seleccione una actividad deportiva";
                return;
            }

            ActividadDeportiva actSelected = adm.buscarActividadDeportiva(idActividad);
            Socio socio = adm.buscarSocio(Session["dni"] as string);

            PagoActividadDeportiva p = new PagoActividadDeportiva(socio, actSelected.PrecioMes, DateTime.Now, actSelected);

            Page.ClientScript.RegisterStartupScript(
                this.GetType(), "OpenWindow", "window.open('https://link.mercadopago.com.ar/clubdeportivo','_newtab');", 
                true
            );
            
            adm.agregarPagoActividadDeportiva(p);

            success.Text = "El pago fue registrado con éxito. Recuerde que el monto debe ser el correcto, de lo contrario no podrá ingresar a la actividad.";
            ddlDeportes.SelectedIndex = 0;
        }
    }
}