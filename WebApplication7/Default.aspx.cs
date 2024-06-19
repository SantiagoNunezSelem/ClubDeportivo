using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.EnterpriseServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WebApplication7 {
    public partial class _Default: Page {

        protected void Page_Load(object sender, EventArgs e) {
            Administradora adm = (Session["adm"] as Administradora);

            if (adm == null){
                adm = new Administradora();
                string err = null;

                adm.setConnectionDBPathWeb(AppDomain.CurrentDomain.BaseDirectory);
                adm.getActividadesDeportivasDB(ref err);
                adm.getSociosDB(ref err);

                Session["adm"] = adm;
            }
        }
        
        protected void onLogin(object sender, EventArgs e) {
            string id = TextBoxID.Text;
            string dni = TextBoxDNI.Text;
            
            Administradora adm = Session["adm"] as Administradora;

            bool isUserValid = adm.validateUser(id, dni);

            if (isUserValid) {
                Session["dni"] = dni;
                Session["id"] = id;

                LabelAp.Text = "Usuario logueado con éxito. Serás redirigido";
                Response.Redirect("Panel.aspx");
            }
            else
                LabelAp.Text = "Usuario no encontrado. Revise los datos ingresados";
        }
    }
}