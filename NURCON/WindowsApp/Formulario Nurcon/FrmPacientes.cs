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
            m.Nombre_Paciente = txtPaciente.Text.Trim().ToUpper();
            m.Matricula = ((Convert.ToInt32(txtMatricula.Text.ToString().Trim().ToUpper())));
            m.Sexo = cboSexo.SelectedItem.ToString();
            m.Edad = ((Convert.ToInt32(txtEdad.Text.ToString().Trim().ToUpper())));
            string mensaje = BusinessLogicLayer.PacienteBLL.insertar(m);


            //----------------------------------------
            //sacar id del paciente que acabamos de registrar

            int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(m.Matricula).ToList()[0].Id;
            // uso la matricula entonces se pone aqui en m.matricula 

            //--------------------------------------
            Diagnostico l = new Diagnostico(); 
            l.Tipo_de_sangre = txtTipo_sangre.Text.Trim().ToUpper();
            l.Medicamentos = cboMedicamentos.SelectedItem.ToString().Trim().ToUpper();
            l.Motivo_de_visita = cboMotivoVisita.SelectedItem.ToString().Trim().ToUpper();
            l.Notas = txtNotas.Text.Trim().ToUpper();
            l.Sintomas = txtSintomas.Text.Trim().ToUpper();
            l.PacienteId = var;

            





            if (string.IsNullOrEmpty(mensaje)&& BusinessLogicLayer.DiagnosticoBLL.insertar(l))
            {
                MessageBox.Show("Registrado correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPaciente.Text = "";
                txtMatricula.Text = "";
                txtEdad.Text = "";
                cboSexo.SelectedItem = null;
                txtNotas.Text = "";
                txtSintomas.Text = "";
                txtTipo_sangre.Text = "";
                cboMedicamentos.SelectedItem = null;
                cboMotivoVisita.SelectedItem = null;


            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

               


                     
                

        



        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVisualizar_Click(object sender, EventArgs e)
        {
            // vamos a visualizar la tabla de diagnostico

            dtgVisualizar.DataSource = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaVisualizar.Text));

            }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvVisualizarEliminacion.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.PacienteBLL.eliminar(Convert.ToInt32(txtMatriculaeliminar.Text));
        }

        private void btnGuardarNDiag_Click(object sender, EventArgs e)
        {
            //sacar id del paciente al que queremos agregar un nuevo diagnostico

            int var = BusinessLogicLayer.PacienteBLL.consultaPormatricula(Convert.ToInt32(txtMatriculaNR.Text)).ToList()[0].Id;
            //crear instancia de diagnostico y agregar valores
            Diagnostico l = new Diagnostico(); 
            l.Tipo_de_sangre = txtTipoSangreND.Text.Trim().ToUpper();
            l.Medicamentos = cboMedicamentosND.SelectedItem.ToString().Trim().ToUpper();
            l.Motivo_de_visita = cboMotivoVisitaND.SelectedItem.ToString().Trim().ToUpper();
            l.Notas = txtNotasND.Text.Trim().ToUpper();
            l.Sintomas = txtSintomasND.Text.Trim().ToUpper();
            l.PacienteId = var;

            //validar que se registro correctamente
            if (BusinessLogicLayer.DiagnosticoBLL.insertar(l))
            {
                MessageBox.Show("Registrado correctamente");
                txtMatriculaNR.Text = "";
                txtSintomasND.Text = "";
                txtTipoSangreND.Text = "";
                cboMedicamentosND.SelectedItem = null;
                txtNotasND.Text = "";
                cboMotivoVisitaND.SelectedItem = null;
 


            }
            else
            {
                MessageBox.Show("Error de inserción", "Error");
            }
        }

      
    }

  
    }

