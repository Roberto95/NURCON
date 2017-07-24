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
            m.Nombre_Paciente = txtPaciente.Text;
            m.Matricula = ((Convert.ToInt32(txtMatricula.Text.ToString())));
            m.Sexo = cboSexo.SelectedItem.ToString();
            m.Edad = ((Convert.ToInt32(txtEdad.Text.ToString())));
            string mensaje = BusinessLogicLayer.PacienteBLL.insertar(m);


            //----------------------------------------
            //sacar id del paciente que acabamos de registrar

            int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(m.Matricula).ToList()[0].Id;
            // uso la matricula entonces se pone aqui en m.matricula 

            //--------------------------------------
            Diagnostico l = new Diagnostico(); 
            l.Tipo_de_sangre = txtTipo_sangre.Text;
            l.Medicamentos = cboMedicamentos.SelectedItem.ToString();
            l.Motivo_de_visita = cboMotivoVisita.SelectedItem.ToString();
            l.Notas = txtSintomas.Text;
            l.Sintomas = txtSintomas.Text;
            l.PacienteId = var;

            string mensajes = BusinessLogicLayer.DiagnosticoBLL.insertar(l);

            

                //if (string.IsNullOrEmpty(mensaje))
                //{
                //    MessageBox.Show("Se registro correctamente");
                //     txtPaciente.Text = "";
                //txtMatricula.Text = "";
                //txtEdad.Text = "";
                //    cboSexo.SelectedItem = null;


                     
                //}
                //else
                //{
                //    MessageBox.Show(mensaje, "Error");
                //}

        }

               


                     
                

        



        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVisualizar_Click(object sender, EventArgs e)
        {

            dtgVisualizar.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //----------------------------------------
            //sacar id del paciente que acabamos de registrar
            int VarNR = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaNR.Text)).ToList()[0].Id;
            // uso la matricula entonces se pone aqui en m.matricula 

            //--------------------------------------
            Diagnostico l = new Diagnostico();
            l.Tipo_de_sangre = txtTipo_sangreNR.Text;
            l.Medicamentos = cboMedicamentosNR.SelectedItem.ToString();
            l.Motivo_de_visita = cboMotivo_visitaNR.SelectedItem.ToString();
            l.Notas = txtNotasNR.Text;
            l.Sintomas = txtSintomasNR.Text;
            l.PacienteId = VarNR;

            BusinessLogicLayer.DiagnosticoBLL.insertar(l);

        }
    }
}
