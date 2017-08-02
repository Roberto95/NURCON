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
          
        }


       


        private void button1_Click(object sender, EventArgs e)
        {
           Paciente p = new Paciente();
           p.Matricula = ((Convert.ToInt32(txtMatriculaModificar.Text.ToString().Trim().ToUpper())));
            p.Nombre_Paciente = txtPacienteModificar.Text.Trim().ToUpper();
           p.Sexo = cboSexoM.SelectedItem.ToString();
            p.Edad = ((Convert.ToInt32(txtEdadM.Text.ToString().Trim().ToUpper())));

            BusinessLogicLayer.PacienteBLL.actualizar(p);
        }
    }

}