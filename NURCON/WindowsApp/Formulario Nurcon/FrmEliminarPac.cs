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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEliminarPac_Load(object sender, EventArgs e)
        {
            txtPacienteEliminar.Enabled = false;
            txtEdad.Enabled = false;
            cboSexo.Enabled = false;
            dgvPacEl.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //txtMatriculaEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtBuscarId.Text)).ToList()[0].Matricula.ToString();
                txtPacienteEliminar.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Nombre_Paciente;
                txtEdad.Text = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Edad.ToString();
                cboSexo.SelectedItem = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaEliminar.Text)).ToList()[0].Sexo;
                
                
            }
            catch
            {
                MessageBox.Show("Introducir Id válido de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
