using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.formulario
{
    public partial class Historialdiagnostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtVisDiagMat_Click(object sender, EventArgs e)
        {
            try
            {
                // vamos a visualizar la tabla de diagnostico

                int id = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMat.Text)).ToList()[0].Id;
                
            dgvVisualizar.DataSource = BusinessLogicLayer.DiagnosticoBLL.consultaIdPac(id);
            dgvVisualizar.DataBind();
            //dgvVisualizar.Columns[].Visible = false;

            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Matricula incorrecta o inexistente en base de datos');</script>");
            }
        }

       

        protected void btnVerDiag_Click(object sender, EventArgs e)
        {
            dgvVisualizar.DataSource = BusinessLogicLayer.DiagnosticoBLL.visualizar();
            dgvVisualizar.DataBind();
            //dgvVisualizar.Columns["PacienteId"].Visible = true;
        }
    }
}

          
            