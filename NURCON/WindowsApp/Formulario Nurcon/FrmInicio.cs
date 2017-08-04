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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

       

        

        private void button1_Click(object sender, EventArgs e)

        {

            // aqui vamos a enlazar al formulario de pacientes
            FrmPacientes frmpacientes= new FrmPacientes();

            frmpacientes.Show();
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FrmPacientes hist = new FrmPacientes();
            hist.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPac mod = new FrmModificarPac();
            mod.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarPac el = new FrmEliminarPac();
            el.ShowDialog();
            
        }
    }
}
