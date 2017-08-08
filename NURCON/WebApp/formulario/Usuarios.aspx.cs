using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BusinessLogicLayer.AdministradorBLL.siHayDatos())
            {
                if (BusinessLogicLayer.AdministradorBLL.iniciarSesionUs(txtUser.Text) && BusinessLogicLayer.AdministradorBLL.iniciarSesionPass(txtPassword.Text))
                {
                    Response.Redirect("inicio.aspx");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Usuario o contraseña incorrectos');</script>");
                    //MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (txtUser.Text == "admin" && txtPassword.Text == "admin")
                {
                    Response.Redirect("cambiarDatos.aspx");
                }
                else
                {
                    
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Usuario o contraseña incorrectos');</script>");
                }
                

            }


        }
    }
}
