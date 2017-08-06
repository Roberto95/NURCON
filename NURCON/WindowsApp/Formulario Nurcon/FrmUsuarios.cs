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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (BusinessLogicLayer.AdministradorBLL.siHayDatos())
            {
                if (BusinessLogicLayer.AdministradorBLL.iniciarSesionUs(txtUser.Text) && BusinessLogicLayer.AdministradorBLL.iniciarSesionPass(txtPassword.Text))
                {
                    this.Hide();
                    FrmInicio prin = new FrmInicio();
                    prin.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                if (txtUser.Text == "admin" && txtPassword.Text == "admin")
                {
                    this.Hide();
                    FrmCambiarDatos cd = new FrmCambiarDatos();
                    cd.ShowDialog();
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 

            
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u25cf';
        }

        
    }
}
