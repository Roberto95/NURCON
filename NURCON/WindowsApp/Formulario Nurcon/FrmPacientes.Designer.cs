namespace WindowsApp.Formulario_Nurcon
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcModificar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.tbHistorial = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txtVisDiagMat = new System.Windows.Forms.TextBox();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMatriculaNR = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtTipo_sangre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMotivoVisita = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVerDiag = new System.Windows.Forms.Button();
            this.btnBuscarVisualizar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedicamentosNDiag = new System.Windows.Forms.TextBox();
            this.txtTipoSangreND = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSintomasND = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNotasND = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboMotivoVisitaND = new System.Windows.Forms.ComboBox();
            this.btnGuardarNDiag = new System.Windows.Forms.Button();
            this.tcModificar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(142, 64);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(67, 18);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // tcModificar
            // 
            this.tcModificar.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcModificar.Controls.Add(this.tabPage1);
            this.tcModificar.Controls.Add(this.tbHistorial);
            this.tcModificar.Controls.Add(this.tabPage5);
            this.tcModificar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcModificar.Location = new System.Drawing.Point(10, 12);
            this.tcModificar.Name = "tcModificar";
            this.tcModificar.SelectedIndex = 0;
            this.tcModificar.Size = new System.Drawing.Size(779, 497);
            this.tcModificar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cboSexo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.Controls.Add(this.txtPaciente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblMatricula);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo paciente y diagnóstico";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboSexo.Location = new System.Drawing.Point(413, 60);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(59, 26);
            this.cboSexo.TabIndex = 26;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(527, 61);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(58, 25);
            this.txtEdad.TabIndex = 8;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMatricula.Location = new System.Drawing.Point(210, 62);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(153, 24);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(264, 25);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(321, 25);
            this.txtPaciente.TabIndex = 2;
            // 
            // tbHistorial
            // 
            this.tbHistorial.BackColor = System.Drawing.Color.White;
            this.tbHistorial.Controls.Add(this.btnVerDiag);
            this.tbHistorial.Controls.Add(this.label20);
            this.tbHistorial.Controls.Add(this.txtVisDiagMat);
            this.tbHistorial.Controls.Add(this.dgvVisualizar);
            this.tbHistorial.Controls.Add(this.btnBuscarVisualizar);
            this.tbHistorial.Location = new System.Drawing.Point(4, 30);
            this.tbHistorial.Name = "tbHistorial";
            this.tbHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tbHistorial.Size = new System.Drawing.Size(771, 463);
            this.tbHistorial.TabIndex = 3;
            this.tbHistorial.Text = "Historial de diagnósticos";
            this.tbHistorial.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(37, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(211, 18);
            this.label20.TabIndex = 1;
            this.label20.Text = "Especificar alumno (matrícula):";
            // 
            // txtVisDiagMat
            // 
            this.txtVisDiagMat.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisDiagMat.Location = new System.Drawing.Point(19, 47);
            this.txtVisDiagMat.Name = "txtVisDiagMat";
            this.txtVisDiagMat.Size = new System.Drawing.Size(253, 25);
            this.txtVisDiagMat.TabIndex = 2;
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.BackgroundColor = System.Drawing.Color.Brown;
            this.dgvVisualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(19, 119);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.Size = new System.Drawing.Size(725, 296);
            this.dgvVisualizar.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox5);
            this.tabPage5.Controls.Add(this.pictureBox6);
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.btnGuardarNDiag);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.txtMatriculaNR);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(771, 463);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nuevo Diagnóstico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(226, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(209, 24);
            this.label25.TabIndex = 1;
            this.label25.Text = "Ingrese  la matricula ";
            // 
            // txtMatriculaNR
            // 
            this.txtMatriculaNR.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculaNR.Location = new System.Drawing.Point(313, 63);
            this.txtMatriculaNR.Name = "txtMatriculaNR";
            this.txtMatriculaNR.Size = new System.Drawing.Size(100, 25);
            this.txtMatriculaNR.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(236, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 18);
            this.label26.TabIndex = 2;
            this.label26.Text = "Matricula:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsApp.Properties.Resources.UTE_logo;
            this.pictureBox4.Location = new System.Drawing.Point(6, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(137, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsApp.Properties.Resources.Patient_Female_icon_icons_com_75052;
            this.pictureBox2.Location = new System.Drawing.Point(658, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.Patient_Male_icon_icons_com_75053;
            this.pictureBox1.Location = new System.Drawing.Point(602, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsApp.Properties.Resources.Caduceus_icon_icons1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.txtTipo_sangre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSintomas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNotas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboMotivoVisita);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 305);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnostico";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamento.Location = new System.Drawing.Point(154, 190);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(121, 25);
            this.txtMedicamento.TabIndex = 15;
            // 
            // txtTipo_sangre
            // 
            this.txtTipo_sangre.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo_sangre.Location = new System.Drawing.Point(154, 68);
            this.txtTipo_sangre.Name = "txtTipo_sangre";
            this.txtTipo_sangre.Size = new System.Drawing.Size(121, 25);
            this.txtTipo_sangre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de sangre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Notas";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.Location = new System.Drawing.Point(440, 52);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(282, 105);
            this.txtSintomas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Motivo Visita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 190);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medicamento";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(440, 173);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(282, 107);
            this.txtNotas.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sintomas";
            // 
            // cboMotivoVisita
            // 
            this.cboMotivoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoVisita.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotivoVisita.FormattingEnabled = true;
            this.cboMotivoVisita.Items.AddRange(new object[] {
            "Accidente",
            "Malestar"});
            this.cboMotivoVisita.Location = new System.Drawing.Point(154, 130);
            this.cboMotivoVisita.Name = "cboMotivoVisita";
            this.cboMotivoVisita.Size = new System.Drawing.Size(121, 26);
            this.cboMotivoVisita.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.BackgroundImage = global::WindowsApp.Properties.Resources.Palomita;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnGuardar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(335, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 44);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVerDiag
            // 
            this.btnVerDiag.BackColor = System.Drawing.Color.White;
            this.btnVerDiag.BackgroundImage = global::WindowsApp.Properties.Resources.medical_49_icon_icons_com_73913;
            this.btnVerDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerDiag.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDiag.ForeColor = System.Drawing.Color.Black;
            this.btnVerDiag.Location = new System.Drawing.Point(621, 26);
            this.btnVerDiag.Name = "btnVerDiag";
            this.btnVerDiag.Size = new System.Drawing.Size(86, 67);
            this.btnVerDiag.TabIndex = 5;
            this.btnVerDiag.Text = "Ver Todos";
            this.btnVerDiag.UseVisualStyleBackColor = false;
            this.btnVerDiag.Click += new System.EventHandler(this.btnVerDiag_Click);
            // 
            // btnBuscarVisualizar
            // 
            this.btnBuscarVisualizar.BackColor = System.Drawing.Color.White;
            this.btnBuscarVisualizar.BackgroundImage = global::WindowsApp.Properties.Resources.descarga;
            this.btnBuscarVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarVisualizar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVisualizar.Location = new System.Drawing.Point(287, 37);
            this.btnBuscarVisualizar.Name = "btnBuscarVisualizar";
            this.btnBuscarVisualizar.Size = new System.Drawing.Size(90, 42);
            this.btnBuscarVisualizar.TabIndex = 3;
            this.btnBuscarVisualizar.Text = "Buscar";
            this.btnBuscarVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarVisualizar.UseVisualStyleBackColor = false;
            this.btnBuscarVisualizar.Click += new System.EventHandler(this.btnBuscarVisualizar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsApp.Properties.Resources.Patient_Female_icon_icons_com_75052;
            this.pictureBox5.Location = new System.Drawing.Point(678, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsApp.Properties.Resources.Patient_Male_icon_icons_com_75053;
            this.pictureBox6.Location = new System.Drawing.Point(622, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 73);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsApp.Properties.Resources.UTE_logo;
            this.pictureBox3.Location = new System.Drawing.Point(17, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::WindowsApp.Properties.Resources.Caduceus_icon_icons1;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.txtMedicamentosNDiag);
            this.groupBox2.Controls.Add(this.txtTipoSangreND);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSintomasND);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtNotasND);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cboMotivoVisitaND);
            this.groupBox2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostico";
            // 
            // txtMedicamentosNDiag
            // 
            this.txtMedicamentosNDiag.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentosNDiag.Location = new System.Drawing.Point(174, 192);
            this.txtMedicamentosNDiag.Name = "txtMedicamentosNDiag";
            this.txtMedicamentosNDiag.Size = new System.Drawing.Size(121, 25);
            this.txtMedicamentosNDiag.TabIndex = 10;
            // 
            // txtTipoSangreND
            // 
            this.txtTipoSangreND.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSangreND.Location = new System.Drawing.Point(174, 78);
            this.txtTipoSangreND.Name = "txtTipoSangreND";
            this.txtTipoSangreND.Size = new System.Drawing.Size(121, 25);
            this.txtTipoSangreND.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tipo de sangre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(401, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Notas";
            // 
            // txtSintomasND
            // 
            this.txtSintomasND.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomasND.Location = new System.Drawing.Point(452, 51);
            this.txtSintomasND.Multiline = true;
            this.txtSintomasND.Name = "txtSintomasND";
            this.txtSintomasND.Size = new System.Drawing.Size(282, 105);
            this.txtSintomasND.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Motivo Visita";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 200);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(101, 18);
            this.label17.TabIndex = 9;
            this.label17.Text = "Medicamentos";
            // 
            // txtNotasND
            // 
            this.txtNotasND.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotasND.Location = new System.Drawing.Point(452, 173);
            this.txtNotasND.Multiline = true;
            this.txtNotasND.Name = "txtNotasND";
            this.txtNotasND.Size = new System.Drawing.Size(282, 107);
            this.txtNotasND.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(374, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 18);
            this.label18.TabIndex = 11;
            this.label18.Text = "Sintomas";
            // 
            // cboMotivoVisitaND
            // 
            this.cboMotivoVisitaND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoVisitaND.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotivoVisitaND.FormattingEnabled = true;
            this.cboMotivoVisitaND.Items.AddRange(new object[] {
            "Accidente",
            "Malestar"});
            this.cboMotivoVisitaND.Location = new System.Drawing.Point(174, 135);
            this.cboMotivoVisitaND.Name = "cboMotivoVisitaND";
            this.cboMotivoVisitaND.Size = new System.Drawing.Size(121, 26);
            this.cboMotivoVisitaND.TabIndex = 8;
            // 
            // btnGuardarNDiag
            // 
            this.btnGuardarNDiag.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarNDiag.BackgroundImage = global::WindowsApp.Properties.Resources.Palomita;
            this.btnGuardarNDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarNDiag.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNDiag.Location = new System.Drawing.Point(288, 403);
            this.btnGuardarNDiag.Name = "btnGuardarNDiag";
            this.btnGuardarNDiag.Size = new System.Drawing.Size(167, 51);
            this.btnGuardarNDiag.TabIndex = 15;
            this.btnGuardarNDiag.Text = "Guardar";
            this.btnGuardarNDiag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarNDiag.UseVisualStyleBackColor = false;
            this.btnGuardarNDiag.Click += new System.EventHandler(this.btnGuardarNDiag_Click);
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(801, 517);
            this.Controls.Add(this.tcModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.tcModificar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbHistorial.ResumeLayout(false);
            this.tbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tcModificar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.ComboBox cboMotivoVisita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.ComboBox cboSexo;
        internal System.Windows.Forms.TabPage tbHistorial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtVisDiagMat;
        private System.Windows.Forms.Button btnBuscarVisualizar;
        private System.Windows.Forms.DataGridView dgvVisualizar;
        private System.Windows.Forms.TextBox txtTipo_sangre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMatriculaNR;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnGuardarNDiag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTipoSangreND;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSintomasND;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNotasND;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Button btnVerDiag;
        private System.Windows.Forms.TextBox txtMedicamentosNDiag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cboMotivoVisitaND;
    }
}