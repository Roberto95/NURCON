using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class pacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                Paciente m = new Paciente();
                m.Nombre_Paciente = txtPaciente.Text.Trim().ToUpper();
                m.Matricula = ((Convert.ToInt32(txtMatricula.Text.ToString().Trim().ToUpper())));
                m.Sexo = cboSexo.SelectedItem.ToString();
                m.Edad = ((Convert.ToInt32(txtEdad.Text.ToString().Trim().ToUpper())));
                string mensaje = BusinessLogicLayer.PacienteBLL.insertar(m);


                //----------------------------------------
                //sacar id del paciente que acabamos de registrar

                int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(m.Matricula).ToList()[0].Id;
                // uso la matricula entonces se pone aqui en m.matricula 

                //--------------------------------------
                Diagnostico l = new Diagnostico();
                l.Tipo_de_sangre = txtTipo_sangre.Text.Trim().ToUpper();
                l.Medicamentos = txtMedicamento.Text.ToString().Trim().ToUpper();
                l.Motivo_de_visita = cboMotivoVisita.SelectedItem.ToString().Trim().ToUpper();
                l.Notas = txtNotas.Text.Trim().ToUpper();
                l.Sintomas = txtSintomas.Text.Trim().ToUpper();
                l.PacienteId = var;

                if (string.IsNullOrEmpty(mensaje) && BusinessLogicLayer.DiagnosticoBLL.insertar(l))
                {
                   // Response.Write("Registrado Correcatamente");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registrado Correctamente');</script>");
                    //MessageBox.Show("Registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaciente.Text = "";
                    txtMatricula.Text = "";
                    txtEdad.Text = "";
                   //cboSexo.SelectedItem = null;
                    txtNotas.Text = "";
                    txtSintomas.Text = "";
                    txtTipo_sangre.Text = "";
                    txtMedicamento.Text = "";
                    //cboMotivoVisita.SelectedItem = null;


                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error');</script>");

                   // Response.Write("eerroorsin");
                    //MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch

            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Campo vacios');</script>");

                // Response.Write("campos vacios");
                //MessageBox.Show("Verificar que los campos no estén vacíos o estén en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicio.aspx");
        }
    }
}