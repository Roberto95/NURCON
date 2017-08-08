using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ModificarPac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DGModificar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
            DGModificar.DataBind();
        }

        protected void btnBuscarModificar_Click(object sender, EventArgs e)
        {
             try
            {
                txtMatModificar.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarID.Text)).ToList()[0].Matricula.ToString();
                txtNombreModificar.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarID.Text)).ToList()[0].Nombre_Paciente;
                txtEdadModificar.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarID.Text)).ToList()[0].Edad.ToString();
                cboSexoM.SelectedItem.Text= BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarID.Text)).ToList()[0].Sexo;
                txtBuscarID.Enabled = false;
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Introducir Id válido de la lista Aviso');</script>");

                //Response.Write("ERROR");

            }
        }





        protected void btnGuardarModi_Click(object sender, EventArgs e)
        {

            try
            {

                string mensaje = "";
                if (BusinessLogicLayer.PacienteBLL.matRepetida(Convert.ToInt32(txtMatModificar.Text)))
                {

                    mensaje = BusinessLogicLayer.PacienteBLL.actualizarMat(Convert.ToInt32(txtMatModificar.Text), Convert.ToInt32(txtBuscarID.Text));
                }

                if (!string.IsNullOrEmpty(mensaje))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error');</script>");

                  //  Response.Write("ERROR");
                }
                else
                {
                    Paciente p = new Paciente();
                    p.Id = Convert.ToInt32(txtBuscarID.Text);
                    p.Matricula = ((Convert.ToInt32(txtMatModificar.Text.ToString().Trim())));
                    p.Nombre_Paciente = txtNombreModificar.Text.Trim().ToUpper();
                    p.Sexo = cboSexoM.SelectedItem.ToString();
                    p.Edad = ((Convert.ToInt32(txtEdadModificar.Text.ToString().Trim().ToUpper())));

                    BusinessLogicLayer.PacienteBLL.actualizar(p);


                    txtBuscarID.Enabled = true;
                    txtBuscarID.Text = "";
                    txtEdadModificar.Text = "";
                    txtMatModificar.Text = "";
                    txtNombreModificar.Text = "";
                    cboSexoM.SelectedItem.Text = null;

                    DGModificar.DataSource = null;
                    DGModificar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
                    // Response.Write("ERROR");
                    //MessageBox.Show("Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Actualizacion correcta');</script>");
                    DGModificar.DataSource = null;
                    DGModificar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
                    DGModificar.DataBind();
                }
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Campo vacios utiice otro formato');</script>");

                //Response.Write("ERROR");
                //MessageBox.Show("Verificar que no haya campos vacíos o utilice el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
    
