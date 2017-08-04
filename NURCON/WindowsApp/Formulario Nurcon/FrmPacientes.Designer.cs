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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcModificar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboSexo = new System.Windows.Forms.ComboBox();
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.tbHistorial = new System.Windows.Forms.TabPage();
            this.btnVerDiag = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtVisDiagMat = new System.Windows.Forms.TextBox();
            this.btnBuscarVisualizar = new System.Windows.Forms.Button();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.label25 = new System.Windows.Forms.Label();
            this.txtMatriculaNR = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tcModificar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(31, 64);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(82, 18);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // tcModificar
            // 
            this.tcModificar.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcModificar.Controls.Add(this.tabPage1);
            this.tcModificar.Controls.Add(this.tbHistorial);
            this.tcModificar.Controls.Add(this.tabPage5);
            this.tcModificar.Location = new System.Drawing.Point(12, 12);
            this.tcModificar.Name = "tcModificar";
            this.tcModificar.SelectedIndex = 0;
            this.tcModificar.Size = new System.Drawing.Size(779, 497);
            this.tcModificar.TabIndex = 10;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo paciente y diagnóstico";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboSexo.Location = new System.Drawing.Point(698, 59);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(59, 26);
            this.cboSexo.TabIndex = 24;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 290);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnostico";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMedicamento.Location = new System.Drawing.Point(137, 168);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(121, 24);
            this.txtMedicamento.TabIndex = 26;
            // 
            // txtTipo_sangre
            // 
            this.txtTipo_sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTipo_sangre.Location = new System.Drawing.Point(137, 51);
            this.txtTipo_sangre.Name = "txtTipo_sangre";
            this.txtTipo_sangre.Size = new System.Drawing.Size(121, 24);
            this.txtTipo_sangre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de sangre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(389, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Notas";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSintomas.Location = new System.Drawing.Point(440, 173);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(282, 105);
            this.txtSintomas.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Motivo Visita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medicamento";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNotas.Location = new System.Drawing.Point(440, 52);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(282, 107);
            this.txtNotas.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(362, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sintomas";
            // 
            // cboMotivoVisita
            // 
            this.cboMotivoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboMotivoVisita.FormattingEnabled = true;
            this.cboMotivoVisita.Items.AddRange(new object[] {
            "Accidente",
            "Malestar"});
            this.cboMotivoVisita.Location = new System.Drawing.Point(137, 113);
            this.cboMotivoVisita.Name = "cboMotivoVisita";
            this.cboMotivoVisita.Size = new System.Drawing.Size(121, 26);
            this.cboMotivoVisita.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(641, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 38);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEdad.Location = new System.Drawing.Point(699, 16);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(58, 24);
            this.txtEdad.TabIndex = 8;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMatricula.Location = new System.Drawing.Point(186, 61);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(153, 24);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPaciente.Location = new System.Drawing.Point(186, 21);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(321, 24);
            this.txtPaciente.TabIndex = 5;
            // 
            // tbHistorial
            // 
            this.tbHistorial.BackColor = System.Drawing.Color.White;
            this.tbHistorial.Controls.Add(this.btnVerDiag);
            this.tbHistorial.Controls.Add(this.label20);
            this.tbHistorial.Controls.Add(this.txtVisDiagMat);
            this.tbHistorial.Controls.Add(this.btnBuscarVisualizar);
            this.tbHistorial.Controls.Add(this.dgvVisualizar);
            this.tbHistorial.Location = new System.Drawing.Point(4, 25);
            this.tbHistorial.Name = "tbHistorial";
            this.tbHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tbHistorial.Size = new System.Drawing.Size(771, 468);
            this.tbHistorial.TabIndex = 3;
            this.tbHistorial.Text = "Historial de diagnósticos";
            this.tbHistorial.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnVerDiag
            // 
            this.btnVerDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnVerDiag.Location = new System.Drawing.Point(645, 59);
            this.btnVerDiag.Name = "btnVerDiag";
            this.btnVerDiag.Size = new System.Drawing.Size(99, 30);
            this.btnVerDiag.TabIndex = 5;
            this.btnVerDiag.Text = "Ver todos";
            this.btnVerDiag.UseVisualStyleBackColor = true;
            this.btnVerDiag.Click += new System.EventHandler(this.btnVerDiag_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(256, 18);
            this.label20.TabIndex = 4;
            this.label20.Text = "Especificar alumno (matrícula):";
            // 
            // txtVisDiagMat
            // 
            this.txtVisDiagMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtVisDiagMat.Location = new System.Drawing.Point(19, 62);
            this.txtVisDiagMat.Name = "txtVisDiagMat";
            this.txtVisDiagMat.Size = new System.Drawing.Size(253, 24);
            this.txtVisDiagMat.TabIndex = 2;
            // 
            // btnBuscarVisualizar
            // 
            this.btnBuscarVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBuscarVisualizar.Location = new System.Drawing.Point(291, 59);
            this.btnBuscarVisualizar.Name = "btnBuscarVisualizar";
            this.btnBuscarVisualizar.Size = new System.Drawing.Size(92, 30);
            this.btnBuscarVisualizar.TabIndex = 1;
            this.btnBuscarVisualizar.Text = "Buscar";
            this.btnBuscarVisualizar.UseVisualStyleBackColor = true;
            this.btnBuscarVisualizar.Click += new System.EventHandler(this.btnBuscarVisualizar_Click);
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(19, 119);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.Size = new System.Drawing.Size(725, 296);
            this.dgvVisualizar.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.btnGuardarNDiag);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.txtMatriculaNR);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(771, 468);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nuevo Diagnóstico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 290);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostico";
            // 
            // txtMedicamentosNDiag
            // 
            this.txtMedicamentosNDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMedicamentosNDiag.Location = new System.Drawing.Point(137, 165);
            this.txtMedicamentosNDiag.Name = "txtMedicamentosNDiag";
            this.txtMedicamentosNDiag.Size = new System.Drawing.Size(121, 24);
            this.txtMedicamentosNDiag.TabIndex = 37;
            // 
            // txtTipoSangreND
            // 
            this.txtTipoSangreND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTipoSangreND.Location = new System.Drawing.Point(137, 51);
            this.txtTipoSangreND.Name = "txtTipoSangreND";
            this.txtTipoSangreND.Size = new System.Drawing.Size(121, 24);
            this.txtTipoSangreND.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tipo de sangre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(389, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Notas";
            // 
            // txtSintomasND
            // 
            this.txtSintomasND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSintomasND.Location = new System.Drawing.Point(440, 173);
            this.txtSintomasND.Multiline = true;
            this.txtSintomasND.Name = "txtSintomasND";
            this.txtSintomasND.Size = new System.Drawing.Size(282, 105);
            this.txtSintomasND.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Motivo Visita";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(6, 173);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(109, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Medicamentos";
            // 
            // txtNotasND
            // 
            this.txtNotasND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNotasND.Location = new System.Drawing.Point(440, 52);
            this.txtNotasND.Multiline = true;
            this.txtNotasND.Name = "txtNotasND";
            this.txtNotasND.Size = new System.Drawing.Size(282, 107);
            this.txtNotasND.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(362, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "Sintomas";
            // 
            // cboMotivoVisitaND
            // 
            this.cboMotivoVisitaND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoVisitaND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboMotivoVisitaND.FormattingEnabled = true;
            this.cboMotivoVisitaND.Items.AddRange(new object[] {
            "Accidente",
            "Malestar"});
            this.cboMotivoVisitaND.Location = new System.Drawing.Point(137, 108);
            this.cboMotivoVisitaND.Name = "cboMotivoVisitaND";
            this.cboMotivoVisitaND.Size = new System.Drawing.Size(121, 26);
            this.cboMotivoVisitaND.TabIndex = 19;
            // 
            // btnGuardarNDiag
            // 
            this.btnGuardarNDiag.Location = new System.Drawing.Point(590, 403);
            this.btnGuardarNDiag.Name = "btnGuardarNDiag";
            this.btnGuardarNDiag.Size = new System.Drawing.Size(167, 51);
            this.btnGuardarNDiag.TabIndex = 35;
            this.btnGuardarNDiag.Text = "Guardar";
            this.btnGuardarNDiag.UseVisualStyleBackColor = true;
            this.btnGuardarNDiag.Click += new System.EventHandler(this.btnGuardarNDiag_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(221, 24);
            this.label25.TabIndex = 34;
            this.label25.Text = "Ingrese  la matricula ";
            // 
            // txtMatriculaNR
            // 
            this.txtMatriculaNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtMatriculaNR.Location = new System.Drawing.Point(124, 63);
            this.txtMatriculaNR.Name = "txtMatriculaNR";
            this.txtMatriculaNR.Size = new System.Drawing.Size(100, 24);
            this.txtMatriculaNR.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(23, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 18);
            this.label26.TabIndex = 26;
            this.label26.Text = "Matricula";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(804, 522);
            this.Controls.Add(this.tcModificar);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.tcModificar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbHistorial.ResumeLayout(false);
            this.tbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.ComboBox cboMotivoVisitaND;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Button btnVerDiag;
        private System.Windows.Forms.TextBox txtMedicamentosNDiag;
    }
}