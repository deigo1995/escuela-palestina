using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebEscuela.Clases;
using System.Data;

namespace WebEscuela.Paginas.Login
{
    public partial class LoginPE : System.Web.UI.Page
    {

        Datos claseDatos = new Datos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string rut = txtEmail.Text;
            string contrasena = txtPass.Text;
            string html1 = string.Empty;
            bool seguir = false;

            DataTable datos = claseDatos.
        }

    }
}