﻿using System;
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            // aqui vamos a enlazar al formulario de pacientes
            FrmPacientes frmpacientes= new FrmPacientes();

            frmpacientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmModificarPac frmModificar = new FrmModificarPac();

            frmModificar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // aqui vamos a enlazar al formulario de pacientes
            FrmEliminarPac frmeliminar = new FrmEliminarPac();

            frmeliminar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
