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
        /*
          <!-- <form onsubmit="onLogin">
                    <div class="textbox">
                        <input type="text" placeholder="Usuario" required>
                    </div>
                    <div class="textbox">
                        <input type="password" placeholder="Contraseña" required>
                    </div>
                    <asp:Button 
                        ID="ButSelec1" 
                        runat="server" 
                        onclick="ButSelec1_Click"  
                        class="btn" 
                        Text="Iniciar Sesión" 
                    />
                </form> -->
         */

        protected void onLogin(object sender, EventArgs e) {
            string id = TextBoxID.Text;
            string dni = TextBoxDNI.Text;
            Response.Write("domain--" + AppDomain.CurrentDomain.BaseDirectory);

            Administradora.staticSetConnectionDBPath(AppDomain.CurrentDomain.BaseDirectory);
            bool isUserValid = Administradora.validateUser(id, dni);

            if (isUserValid) {
                Session["dni"] = dni;
                Session["id"] = id;

                LabelAp.Text = "Usuario logueado con éxito. Serás redirigido";
                Response.Redirect("Dashboard.aspx");
            }
            else
                LabelAp.Text = "Usuario no encontrado. Revise los datos ingresados";
        }
    }
}