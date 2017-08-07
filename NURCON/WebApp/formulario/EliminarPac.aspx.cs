using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class EliminarPac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //txtMatriculaEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Matricula.ToString();
                txtPacienteEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Nombre_Paciente;
                txtEdadEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Edad.ToString();
                cboSexoEliminar.SelectedItem.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Sexo;
               // cboSexoEliminar.SelectedItem.Selected}

            }
            catch
            {
                //Response.Write("Error");
                //MessageBox.Show("Introducir matricula válida de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

               

               
                    int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Id;
                    BusinessLogicLayer.DiagnosticoBLL.eliminarDiag(var);
                    BusinessLogicLayer.PacienteBLL.eliminacion_paciente(Convert.ToInt32(txtMatriculaEliminar.Text));
                    txtEdadEliminar.Text = "";
                    txtMatriculaEliminar.Text = "";
                    txtPacienteEliminar.Text = "";
                    //cboSexoEliminar.SelectedItem = null;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Paciente Eliminado');</script>");
                    //Response.Write("error");
                    // MessageBox.Show("Paciente y sus diagnósticos eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error espacios en blancos');</script>");
               // Response.Write("error");
                //   MessageBox.Show("Verifique que no haya espacios en blanco y sea el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GVEliminar.DataSource = null;
            GVEliminar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }
    }
    }

