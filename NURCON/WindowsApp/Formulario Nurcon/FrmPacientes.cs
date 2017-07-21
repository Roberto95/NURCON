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
using BusinessLogicLayer;



namespace WindowsApp.Formulario_Nurcon
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paciente m = new Paciente();
           
            m.Nombre_Paciente= txtPaciente.Text;
             m.Matricula = ((Convert.ToInt32(txtMatricula.Text.ToString())));
            m.Sexo = cboSexo.SelectedItem.ToString();
            m.Edad = ((Convert.ToInt32(txtEdad.Text.ToString()))); ;
           

                
                string mensaje = BusinessLogicLayer.PacienteBLL.insertar(m);
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("Se registro correctamente");
                     txtPaciente.Text = "";
                txtMatricula.Text = "";
                txtEdad.Text = "";
                    cboSexo.SelectedItem = null;


                     
                }
                else
                {
                    MessageBox.Show(mensaje, "Error");
                }

        }
    }
}
