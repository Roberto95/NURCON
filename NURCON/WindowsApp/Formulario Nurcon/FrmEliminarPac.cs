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

        private void button1_Click(object sender, EventArgs e)
        {

            Paciente elimi = new Paciente();
            elimi.Nombre_Paciente = txtPacienteEliminar.Text.Trim().ToUpper();
            elimi.Matricula = ((Convert.ToInt32(txtMatriculaEliminar.Text.ToString().Trim().ToUpper())));
            elimi.Sexo = cboSexoEliminar.SelectedItem.ToString();
            elimi.Edad = ((Convert.ToInt32(txtEdadEliminar.Text.ToString().Trim().ToUpper()))); 

            BusinessLogicLayer.PacienteBLL.eliminacion_paciente(Convert.ToInt32(txtMatriculaEliminar.Text));

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
                MessageBox.Show("Introducir Id válido de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
