using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // aqui vamos a enlazar al formulario de pacientes
           
            Response.Redirect("pacientes.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("ModificarPac.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarPac.aspx", true);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Telefonos.aspx", true);

        }

        protected void btnHistorial_Click(object sender, EventArgs e)
        {
            Response.Redirect("Historialdiagnostico.aspx", true);
        }

        protected void btnNuevoDiagnostico_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoDiagnostico.aspx", true);
        }
    }

    }
