using CapaNegocio;
using CapaDatos; // ONLY FOR DEV
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


namespace WebApplication7 {
    public partial class _Default: Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ButSelec1_Click(object sender, EventArgs e) {
            LabelAp.Text = "ola loko";

            String l = "";
            List<ArrayList> lista = new List<ArrayList>();
            Datos.getSocios(lista, ref l);
            String k = "";

            for (int i = 0; i < lista.Count; i++)
                k += lista[i];

            LabelAp.Text = "asdasd";
        }

        protected void inputNameChange() {
        }

        protected void onLogin(object sender, EventArgs e) {
            string id = TextBoxID.Text;
            string dni = TextBoxDNI.Text;

            Administradora.staticSetConnectionDBPath(AppDomain.CurrentDomain.BaseDirectory);
            bool isUserValid = Administradora.validateUser(id, dni);

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