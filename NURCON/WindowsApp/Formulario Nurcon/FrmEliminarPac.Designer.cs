namespace WindowsApp.Formulario_Nurcon
{
    partial class FrmEliminarPac
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboSexoEliminar = new System.Windows.Forms.ComboBox();
            this.txtEdadEliminar = new System.Windows.Forms.TextBox();
            this.txtPacienteEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatriculaEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacEl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacEl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(556, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 38);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(299, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 25);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboSexoEliminar
            // 
            this.cboSexoEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboSexoEliminar.FormattingEnabled = true;
            this.cboSexoEliminar.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboSexoEliminar.Location = new System.Drawing.Point(613, 73);
            this.cboSexoEliminar.Name = "cboSexoEliminar";
            this.cboSexoEliminar.Size = new System.Drawing.Size(59, 26);
            this.cboSexoEliminar.TabIndex = 42;
            // 
            // txtEdadEliminar
            // 
            this.txtEdadEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEdadEliminar.Location = new System.Drawing.Point(614, 30);
            this.txtEdadEliminar.Name = "txtEdadEliminar";
            this.txtEdadEliminar.Size = new System.Drawing.Size(58, 24);
            this.txtEdadEliminar.TabIndex = 41;
            // 
            // txtPacienteEliminar
            // 
            this.txtPacienteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPacienteEliminar.Location = new System.Drawing.Point(193, 73);
            this.txtPacienteEliminar.Name = "txtPacienteEliminar";
            this.txtPacienteEliminar.Size = new System.Drawing.Size(321, 24);
            this.txtPacienteEliminar.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Edad";
            // 
            // txtMatriculaEliminar
            // 
            this.txtMatriculaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMatriculaEliminar.Location = new System.Drawing.Point(193, 26);
            this.txtMatriculaEliminar.Name = "txtMatriculaEliminar";
            this.txtMatriculaEliminar.Size = new System.Drawing.Size(100, 24);
            this.txtMatriculaEliminar.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Introducir Matricula";
            // 
            // dgvPacEl
            // 
            this.dgvPacEl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacEl.Location = new System.Drawing.Point(12, 164);
            this.dgvPacEl.Name = "dgvPacEl";
            this.dgvPacEl.Size = new System.Drawing.Size(660, 199);
            this.dgvPacEl.TabIndex = 45;
            // 
            // FrmEliminarPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 375);
            this.Controls.Add(this.dgvPacEl);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboSexoEliminar);
            this.Controls.Add(this.txtEdadEliminar);
            this.Controls.Add(this.txtPacienteEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatriculaEliminar);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarPac";
            this.Text = "FrmEliminarPac";
            this.Load += new System.EventHandler(this.FrmEliminarPac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacEl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboSexoEliminar;
        private System.Windows.Forms.TextBox txtEdadEliminar;
        private System.Windows.Forms.TextBox txtPacienteEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatriculaEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPacEl;
    }
}