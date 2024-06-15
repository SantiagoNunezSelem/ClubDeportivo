using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7 {
    public partial class About: Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                string idSocio = (Session["id"] as string);

                Administradora.obtenerActividadesInscriptasPara(idSocio);
                // Simulación de datos en una lista
                List<Deporte> deportes = new List<Deporte>
                {
                new Deporte { Id = 1, Nombre = "Natación",Horario  = "Lunes y miércoles", PrecioMes = "20000", Profesor = "Pablo"},
                new Deporte { Id = 2, Nombre = "Voley", Horario = "Martes y jueves", PrecioMes ="16000", Profesor = "Juan"},
                new Deporte { Id = 3, Nombre = "Futbol", Horario = "Viernes y sábado", PrecioMes="18000", Profesor = "Claudia" }
            };

                // Enlazar datos al GridView
                GridView1.DataSource = deportes;
                GridView1.DataBind();
            }
        }

        // Clase para simular los datos de deportes
        public class Deporte {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Profesor { get; set; }
            public string Horario { get; set; }
            public string PrecioMes { get; set; }

        }
    }
}