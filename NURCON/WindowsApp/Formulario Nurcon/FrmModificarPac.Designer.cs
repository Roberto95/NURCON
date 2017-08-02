namespace WindowsApp.Formulario_Nurcon
{
    partial class FrmModificarPac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatriculaModificar = new System.Windows.Forms.TextBox();
            this.cboSexoM = new System.Windows.Forms.ComboBox();
            this.txtEdadM = new System.Windows.Forms.TextBox();
            this.txtPacienteModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPacModificar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(95, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txtMatriculaModificar
            // 
            this.txtMatriculaModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMatriculaModificar.Location = new System.Drawing.Point(193, 132);
            this.txtMatriculaModificar.Name = "txtMatriculaModificar";
            this.txtMatriculaModificar.Size = new System.Drawing.Size(100, 24);
            this.txtMatriculaModificar.TabIndex = 1;
            // 
            // cboSexoM
            // 
            this.cboSexoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboSexoM.FormattingEnabled = true;
            this.cboSexoM.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboSexoM.Location = new System.Drawing.Point(613, 79);
            this.cboSexoM.Name = "cboSexoM";
            this.cboSexoM.Size = new System.Drawing.Size(59, 26);
            this.cboSexoM.TabIndex = 32;
            // 
            // txtEdadM
            // 
            this.txtEdadM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEdadM.Location = new System.Drawing.Point(614, 36);
            this.txtEdadM.Name = "txtEdadM";
            this.txtEdadM.Size = new System.Drawing.Size(58, 24);
            this.txtEdadM.TabIndex = 31;
            // 
            // txtPacienteModificar
            // 
            this.txtPacienteModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPacienteModificar.Location = new System.Drawing.Point(193, 87);
            this.txtPacienteModificar.Name = "txtPacienteModificar";
            this.txtPacienteModificar.Size = new System.Drawing.Size(321, 24);
            this.txtPacienteModificar.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Edad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(299, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 25);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(556, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 38);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPacModificar
            // 
            this.dgvPacModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacModificar.Location = new System.Drawing.Point(15, 170);
            this.dgvPacModificar.Name = "dgvPacModificar";
            this.dgvPacModificar.Size = new System.Drawing.Size(654, 188);
            this.dgvPacModificar.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Buscar por Id";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBuscarId.Location = new System.Drawing.Point(193, 36);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(100, 24);
            this.txtBuscarId.TabIndex = 37;
            // 
            // FrmModificarPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 370);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPacModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboSexoM);
            this.Controls.Add(this.txtEdadM);
            this.Controls.Add(this.txtPacienteModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatriculaModificar);
            this.Controls.Add(this.label1);
            this.Name = "FrmModificarPac";
            this.Text = "FrmModificarPac";
            this.Load += new System.EventHandler(this.FrmModificarPac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatriculaModificar;
        private System.Windows.Forms.ComboBox cboSexoM;
        private System.Windows.Forms.TextBox txtEdadM;
        private System.Windows.Forms.TextBox txtPacienteModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPacModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarId;
    }
}