using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static WebApplication7.About;

namespace WebApplication7 {
    public partial class About: Page {
        Administradora adm;

       protected void Page_Load(object sender, EventArgs e) {
            // Se supone que la instancia ya está creada (Page_Load en Default.aspx.cs)
            this.adm = (Session["adm"] as Administradora);

            if(adm == null)                  
                Response.Redirect("Default.aspx");

            string idSocio = (Session["id"] as string);
            string errorMessage = null;
            string dni = Session["dni"] as string;

            adm.getSociosDB(ref errorMessage);

            Socio socio = adm.buscarSocio(dni);
                
            List<PagoActividadDeportiva> pagosAct = socio.getPagosActividadDeportiva();
            List<ActividadDeportiva> actsActivas = new List<ActividadDeportiva>();
                
            pagosAct.ForEach(p => {
                ActividadDeportiva tmpAct = p.ActividadDeportivaInfo;

                if (socio.tieneActividadDeportivaActiva(tmpAct))
                    actsActivas.Add(tmpAct);
            });

            List<Deporte> deportesView = new List<Deporte>();

            for(int i = 0; i < actsActivas.Count; i++) {
                ActividadDeportiva tmpAct = actsActivas[i];

                deportesView.Add(new Deporte {
                    Nombre = tmpAct.Nombre,
                    Horario = tmpAct.Horario,
                    PrecioMes = tmpAct.PrecioMes.ToString(),
                    Profesor = tmpAct.NombreProfesor
                });
            }

            GridView1.DataSource = deportesView;
            GridView1.DataBind();
       }

        // Clase para simular los datos de deportes
        public class Deporte {
            public string Nombre { get; set; }
            public string Profesor { get; set; }
            public string Horario { get; set; }
            public string PrecioMes { get; set; }
        }
    }
}