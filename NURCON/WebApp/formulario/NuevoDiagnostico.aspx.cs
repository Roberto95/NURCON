using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.formulario
{
    public partial class NuevoDiagnostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarNDiag_Click(object sender, EventArgs e)
        {
            //sacar id del paciente al que queremos agregar un nuevo diagnostico
            try
            {
                if (!BusinessLogicLayer.PacienteBLL.matRepetida(Convert.ToInt32(txtMatriculaNR.Text)))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Matricula inexistente en base de datos');</script>");

                    //MessageBox.Show("Matricula inexistente en base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaNR.Text)).ToList()[0].Id;
                    //crear instancia de diagnostico y agregar valores
                    Diagnostico l = new Diagnostico();
                    l.Tipo_de_sangre = txtTipoSangreND.Text.Trim().ToUpper();
                    l.Medicamentos = txtMedicamentosNDiag.Text.ToString().Trim().ToUpper();
                    l.Motivo_de_visita = cboMotivoVisitaND.SelectedItem.ToString().Trim().ToUpper();
                    l.Notas = txtNotasND.Text.Trim().ToUpper();
                    l.Sintomas = txtSintomasND.Text.Trim().ToUpper();
                    l.PacienteId = var;

                    //validar que se registro correctamente
                    if (BusinessLogicLayer.DiagnosticoBLL.insertar(l))
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registrado correctamente');</script>");

                       // MessageBox.Show("Registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatriculaNR.Text = "";
                        txtSintomasND.Text = "";
                        txtTipoSangreND.Text = "";
                        txtMedicamentosNDiag.Text = "";
                        txtNotasND.Text = "";
                        //cboMotivoVisitaND.SelectedItem = null;
                    }
                }



            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Verifique que los campos no estén vacíos y estén en el formato correcto');</script>");

                //MessageBox.Show("Verifique que los campos no estén vacíos y estén en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicio.aspx");
        }
    }
}