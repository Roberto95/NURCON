using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.formulario
{
    public partial class cambiarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Por motivos de seguridad, se debe cambiar el nombre de usuario y la contraseña');</script>");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";
                Administrador ad = new Administrador();

                if (txtPassword.Text == txtPassConf.Text)
                {
                    ad.NombreUsuario = txtUser.Text;
                    ad.Password_ = txtPassConf.Text;
                    mensaje = BusinessLogicLayer.AdministradorBLL.insertar(ad);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('La confirmación de la contraseña no coincide');</script>");
                    
                }

                if (string.IsNullOrEmpty(mensaje))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error en la inserción de datos');</script>");


                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert(mensaje);</script>");
                   
                    Response.Redirect("inicio.aspx");
                }
            }

            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('No dejar espacios en blanco');</script>");
            }
        }
    }
}