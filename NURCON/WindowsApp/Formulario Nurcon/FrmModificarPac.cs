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
    public partial class FrmModificarPac : Form
    {
        public FrmModificarPac()
        {
            InitializeComponent();
        }

        private void FrmModificarPac_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer.PacienteBLL.eliminar(Convert.ToInt32(txtMatriculaeliminar.Text));
        }
    }
}
