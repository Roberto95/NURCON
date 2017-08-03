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
    public partial class FrmEliminarPac : Form
    {
        public FrmEliminarPac()
        {
            InitializeComponent();
        }

        

        private void FrmEliminarPac_Load(object sender, EventArgs e)
        {
            txtPacienteEliminar.Enabled = false;
            txtEdadEliminar.Enabled = false;
            cboSexoEliminar.Enabled = false;
            dgvPacEl.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //txtMatriculaEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Matricula.ToString();
                txtPacienteEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Nombre_Paciente;
                txtEdadEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Edad.ToString();
                cboSexoEliminar.SelectedItem = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Sexo;
                
                
            }
            catch
            {
                MessageBox.Show("Introducir matricula válida de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {

                if (MessageBox.Show("¿Está seguro de eliminar al paciente? Se eliminarán todos los diagnosticos asociados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                    int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Id;
                    BusinessLogicLayer.DiagnosticoBLL.eliminarDiag(var);
                    BusinessLogicLayer.PacienteBLL.eliminacion_paciente(Convert.ToInt32(txtMatriculaEliminar.Text));
                    txtEdadEliminar.Text = "";
                    txtMatriculaEliminar.Text = "";
                    txtPacienteEliminar.Text = "";
                    cboSexoEliminar.SelectedItem = null;
                    MessageBox.Show("Paciente y sus diagnósticos eliminado correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }


            }
            catch
            {
                MessageBox.Show("Verifique que no haya espacios en blanco y sea el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            dgvPacEl.DataSource = null;
            dgvPacEl.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();

        }
    }
}
