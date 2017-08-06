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
    public partial class FrmCambiarDatos : Form
    {
        public FrmCambiarDatos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                string mensaje = "";
                Administrador ad = new Administrador();
                
                if (txtPass.Text == txtConfPass.Text)
                {
                    ad.NombreUsuario = txtUsername.Text;
                    ad.Password_ = txtConfPass.Text;
                    mensaje= BusinessLogicLayer.AdministradorBLL.insertar(ad); 
                }
                else {
                    MessageBox.Show("La confirmación de la contraseña no coincide", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("Error en la insercion de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FrmInicio ini = new FrmInicio();
                    ini.ShowDialog();
                }
            }

            catch {
                MessageBox.Show("No dejar espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
