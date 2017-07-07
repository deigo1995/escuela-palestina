using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebEscuela.Clases;

namespace WebEscuela.Paginas.Login
{
    public partial class LoginNa : System.Web.UI.Page
    {

        Datos claseDatos = new Datos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string rut = "";
            string contrasena = "";

            rut = txtRut.Text;
            contrasena = txtPassword.Text;
            string html1 = string.Empty;
            bool seguir = false;

            DataTable datos = claseDatos.consultaLoginA();

            foreach (DataRow item in datos.Rows)
            {
                if (rut.Equals(item["id_rut"]) && contrasena.Equals(item["contra_al"]))
                {
                    string ID = item["id_rut"].ToString();
                    Response.Redirect("../Paneles/Apoderados.aspx?ID" + ID);
                    seguir = true;
                }
            }

            if (seguir == false)
            {
                html1 += "<div class='alert alert-danger alert-dismissable'>";
                html1 += "<button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>";
                html1 += "<h4><i class='icon fa fa-ban'></i> Revise sus datos!</h4>";
                html1 += "Correo o contraseña incorrectas. Intente nuevamente";
                html1 += "</div>";
                alerta.Text = html1;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Principal/Index.aspx");
        }
    }
}