using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.Formulario_Nurcon
{
    public partial class FrmModificarPac : Form
    {
        public FrmModificarPac()
        {
            InitializeComponent();
        }

        private void FrmModificarPac_Load(object sender, EventArgs e)
        {
            dgvPacModificar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                txtMatriculaModificar.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Matricula.ToString();
                txtPacienteModificar.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Nombre_Paciente;
                txtEdadM.Text = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Edad.ToString();
                cboSexoM.SelectedItem = BusinessLogicLayer.PacienteBLL.consultaPorID(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Sexo;
                txtBuscarId.Enabled = false;
            }
            catch {
                MessageBox.Show("Introducir Id válido de la lista","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try {
                string mensaje="";
                if (BusinessLogicLayer.PacienteBLL.matRepetida(Convert.ToInt32(txtMatriculaModificar.Text))) {
                    
                    mensaje = BusinessLogicLayer.PacienteBLL.actualizarMat(Convert.ToInt32(txtMatriculaModificar.Text), Convert.ToInt32(txtBuscarId.Text));
                }
                
                if (!string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Paciente p = new Paciente();
                    p.Id = Convert.ToInt32(txtBuscarId.Text);
                    p.Matricula = ((Convert.ToInt32(txtMatriculaModificar.Text.ToString().Trim())));
                    p.Nombre_Paciente = txtPacienteModificar.Text.Trim().ToUpper();
                    p.Sexo = cboSexoM.SelectedItem.ToString();
                    p.Edad = ((Convert.ToInt32(txtEdadM.Text.ToString().Trim().ToUpper())));

                    BusinessLogicLayer.PacienteBLL.actualizar(p);


                    txtBuscarId.Enabled = true;
                    txtBuscarId.Text = "";
                    txtEdadM.Text = "";
                    txtMatriculaModificar.Text = "";
                    txtPacienteModificar.Text = "";
                    cboSexoM.SelectedItem = null;

                    dgvPacModificar.DataSource = null;
                    dgvPacModificar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
                }
            }
            catch {
                MessageBox.Show("Verificar que no haya campos vacíos o utilice el formato correcto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            
        }
    }

}