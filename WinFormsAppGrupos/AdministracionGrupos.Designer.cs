namespace WinFormsAppGrupos
{
    partial class FrmAdminGrupos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearGrupos = new System.Windows.Forms.Button();
            this.gbCrearGrupos = new System.Windows.Forms.GroupBox();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.txtCodigoGrupo = new System.Windows.Forms.TextBox();
            this.lblCodigoGrupo = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.btnAdministrarGrupos = new System.Windows.Forms.Button();
            this.cboGrupos = new System.Windows.Forms.ComboBox();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.gbAdministrarGrupos = new System.Windows.Forms.GroupBox();
            this.chkSinGrupo = new System.Windows.Forms.CheckBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.btnAgregarAlGrupo = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnVerInfoGrupos = new System.Windows.Forms.Button();
            this.gbVerInfoGrupos = new System.Windows.Forms.GroupBox();
            this.btnListarGrupos = new System.Windows.Forms.Button();
            this.dgvListarGrupos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCrearGrupos.SuspendLayout();
            this.gbAdministrarGrupos.SuspendLayout();
            this.gbVerInfoGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearGrupos
            // 
            this.btnCrearGrupos.Location = new System.Drawing.Point(29, 112);
            this.btnCrearGrupos.Name = "btnCrearGrupos";
            this.btnCrearGrupos.Size = new System.Drawing.Size(186, 54);
            this.btnCrearGrupos.TabIndex = 0;
            this.btnCrearGrupos.Text = "Crear Grupos";
            this.btnCrearGrupos.UseVisualStyleBackColor = true;
            // 
            // gbCrearGrupos
            // 
            this.gbCrearGrupos.Controls.Add(this.btnCrearGrupo);
            this.gbCrearGrupos.Controls.Add(this.txtCodigoGrupo);
            this.gbCrearGrupos.Controls.Add(this.lblCodigoGrupo);
            this.gbCrearGrupos.Controls.Add(this.txtNombreGrupo);
            this.gbCrearGrupos.Controls.Add(this.lblNombreGrupo);
            this.gbCrearGrupos.Location = new System.Drawing.Point(289, 23);
            this.gbCrearGrupos.Name = "gbCrearGrupos";
            this.gbCrearGrupos.Size = new System.Drawing.Size(968, 219);
            this.gbCrearGrupos.TabIndex = 1;
            this.gbCrearGrupos.TabStop = false;
            this.gbCrearGrupos.Text = "Crear Grupos";
            this.gbCrearGrupos.Enter += new System.EventHandler(this.gbCrearGrupos_Enter);
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(28, 161);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(178, 39);
            this.btnCrearGrupo.TabIndex = 4;
            this.btnCrearGrupo.Text = "Crear Grupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // txtCodigoGrupo
            // 
            this.txtCodigoGrupo.Location = new System.Drawing.Point(232, 43);
            this.txtCodigoGrupo.Name = "txtCodigoGrupo";
            this.txtCodigoGrupo.Size = new System.Drawing.Size(208, 31);
            this.txtCodigoGrupo.TabIndex = 3;
            // 
            // lblCodigoGrupo
            // 
            this.lblCodigoGrupo.AutoSize = true;
            this.lblCodigoGrupo.Location = new System.Drawing.Point(27, 43);
            this.lblCodigoGrupo.Name = "lblCodigoGrupo";
            this.lblCodigoGrupo.Size = new System.Drawing.Size(164, 25);
            this.lblCodigoGrupo.TabIndex = 2;
            this.lblCodigoGrupo.Text = "Código del Grupo: ";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(232, 97);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(453, 31);
            this.txtNombreGrupo.TabIndex = 1;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(28, 100);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(166, 25);
            this.lblNombreGrupo.TabIndex = 0;
            this.lblNombreGrupo.Text = "Nombre del Grupo:";
            // 
            // btnAdministrarGrupos
            // 
            this.btnAdministrarGrupos.Location = new System.Drawing.Point(29, 206);
            this.btnAdministrarGrupos.Name = "btnAdministrarGrupos";
            this.btnAdministrarGrupos.Size = new System.Drawing.Size(186, 52);
            this.btnAdministrarGrupos.TabIndex = 2;
            this.btnAdministrarGrupos.Text = "Administrar Grupos";
            this.btnAdministrarGrupos.UseVisualStyleBackColor = true;
            // 
            // cboGrupos
            // 
            this.cboGrupos.FormattingEnabled = true;
            this.cboGrupos.Location = new System.Drawing.Point(539, 75);
            this.cboGrupos.Name = "cboGrupos";
            this.cboGrupos.Size = new System.Drawing.Size(393, 33);
            this.cboGrupos.TabIndex = 4;
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Location = new System.Drawing.Point(449, 78);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(74, 25);
            this.lblGrupos.TabIndex = 5;
            this.lblGrupos.Text = "Grupos:";
            // 
            // gbAdministrarGrupos
            // 
            this.gbAdministrarGrupos.Controls.Add(this.chkSinGrupo);
            this.gbAdministrarGrupos.Controls.Add(this.lblAlumnos);
            this.gbAdministrarGrupos.Controls.Add(this.btnMostrarAlumnos);
            this.gbAdministrarGrupos.Controls.Add(this.btnAgregarAlGrupo);
            this.gbAdministrarGrupos.Controls.Add(this.lstAlumnos);
            this.gbAdministrarGrupos.Controls.Add(this.cboGrupos);
            this.gbAdministrarGrupos.Controls.Add(this.lblGrupos);
            this.gbAdministrarGrupos.Location = new System.Drawing.Point(289, 261);
            this.gbAdministrarGrupos.Name = "gbAdministrarGrupos";
            this.gbAdministrarGrupos.Size = new System.Drawing.Size(968, 380);
            this.gbAdministrarGrupos.TabIndex = 6;
            this.gbAdministrarGrupos.TabStop = false;
            this.gbAdministrarGrupos.Text = "Administrar Grupos";
            // 
            // chkSinGrupo
            // 
            this.chkSinGrupo.AutoSize = true;
            this.chkSinGrupo.Location = new System.Drawing.Point(770, 237);
            this.chkSinGrupo.Name = "chkSinGrupo";
            this.chkSinGrupo.Size = new System.Drawing.Size(116, 29);
            this.chkSinGrupo.TabIndex = 11;
            this.chkSinGrupo.Text = "Sin grupo";
            this.chkSinGrupo.UseVisualStyleBackColor = true;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(27, 39);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(83, 25);
            this.lblAlumnos.TabIndex = 9;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(539, 233);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(167, 34);
            this.btnMostrarAlumnos.TabIndex = 8;
            this.btnMostrarAlumnos.Text = "Mostrar Alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnAgregarAlGrupo
            // 
            this.btnAgregarAlGrupo.Location = new System.Drawing.Point(539, 154);
            this.btnAgregarAlGrupo.Name = "btnAgregarAlGrupo";
            this.btnAgregarAlGrupo.Size = new System.Drawing.Size(167, 34);
            this.btnAgregarAlGrupo.TabIndex = 7;
            this.btnAgregarAlGrupo.Text = "Agregar al Grupo";
            this.btnAgregarAlGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarAlGrupo.Click += new System.EventHandler(this.btnAgregarAlGrupo_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 25;
            this.lstAlumnos.Location = new System.Drawing.Point(27, 75);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(413, 279);
            this.lstAlumnos.TabIndex = 6;
            // 
            // btnVerInfoGrupos
            // 
            this.btnVerInfoGrupos.Location = new System.Drawing.Point(29, 299);
            this.btnVerInfoGrupos.Name = "btnVerInfoGrupos";
            this.btnVerInfoGrupos.Size = new System.Drawing.Size(186, 53);
            this.btnVerInfoGrupos.TabIndex = 7;
            this.btnVerInfoGrupos.Text = "Ver Info Grupos";
            this.btnVerInfoGrupos.UseVisualStyleBackColor = true;
            // 
            // gbVerInfoGrupos
            // 
            this.gbVerInfoGrupos.Controls.Add(this.btnListarGrupos);
            this.gbVerInfoGrupos.Controls.Add(this.dgvListarGrupos);
            this.gbVerInfoGrupos.Location = new System.Drawing.Point(289, 663);
            this.gbVerInfoGrupos.Name = "gbVerInfoGrupos";
            this.gbVerInfoGrupos.Size = new System.Drawing.Size(968, 348);
            this.gbVerInfoGrupos.TabIndex = 8;
            this.gbVerInfoGrupos.TabStop = false;
            this.gbVerInfoGrupos.Text = "Información de Grupos";
            // 
            // btnListarGrupos
            // 
            this.btnListarGrupos.Location = new System.Drawing.Point(15, 286);
            this.btnListarGrupos.Name = "btnListarGrupos";
            this.btnListarGrupos.Size = new System.Drawing.Size(156, 47);
            this.btnListarGrupos.TabIndex = 1;
            this.btnListarGrupos.Text = "Listar Grupos";
            this.btnListarGrupos.UseVisualStyleBackColor = true;
            this.btnListarGrupos.Click += new System.EventHandler(this.btnListarGrupos_Click);
            // 
            // dgvListarGrupos
            // 
            this.dgvListarGrupos.AllowUserToAddRows = false;
            this.dgvListarGrupos.AllowUserToDeleteRows = false;
            this.dgvListarGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colGrupo,
            this.colCantidadAlumnos});
            this.dgvListarGrupos.Location = new System.Drawing.Point(15, 39);
            this.dgvListarGrupos.Name = "dgvListarGrupos";
            this.dgvListarGrupos.ReadOnly = true;
            this.dgvListarGrupos.RowHeadersWidth = 62;
            this.dgvListarGrupos.RowTemplate.Height = 33;
            this.dgvListarGrupos.Size = new System.Drawing.Size(917, 228);
            this.dgvListarGrupos.TabIndex = 0;
            this.dgvListarGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarGrupos_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 150;
            // 
            // colGrupo
            // 
            this.colGrupo.HeaderText = "Grupo";
            this.colGrupo.MinimumWidth = 8;
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.ReadOnly = true;
            this.colGrupo.Width = 600;
            // 
            // colCantidadAlumnos
            // 
            this.colCantidadAlumnos.HeaderText = "Cantidad de Alumnos";
            this.colCantidadAlumnos.MinimumWidth = 8;
            this.colCantidadAlumnos.Name = "colCantidadAlumnos";
            this.colCantidadAlumnos.ReadOnly = true;
            this.colCantidadAlumnos.Width = 253;
            // 
            // FrmAdminGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1042);
            this.Controls.Add(this.gbVerInfoGrupos);
            this.Controls.Add(this.btnVerInfoGrupos);
            this.Controls.Add(this.gbAdministrarGrupos);
            this.Controls.Add(this.btnAdministrarGrupos);
            this.Controls.Add(this.gbCrearGrupos);
            this.Controls.Add(this.btnCrearGrupos);
            this.Name = "FrmAdminGrupos";
            this.Text = "Administración de Grupos";
            this.Load += new System.EventHandler(this.FrmAdminGrupos_Load);
            this.gbCrearGrupos.ResumeLayout(false);
            this.gbCrearGrupos.PerformLayout();
            this.gbAdministrarGrupos.ResumeLayout(false);
            this.gbAdministrarGrupos.PerformLayout();
            this.gbVerInfoGrupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearGrupos;
        private System.Windows.Forms.GroupBox gbCrearGrupos;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.TextBox txtCodigoGrupo;
        private System.Windows.Forms.Label lblCodigoGrupo;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Button btnAdministrarGrupos;
        private System.Windows.Forms.ComboBox cboGrupos;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.GroupBox gbAdministrarGrupos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Button btnAgregarAlGrupo;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.CheckBox chkSinGrupo;
        private System.Windows.Forms.Button btnVerInfoGrupos;
        private System.Windows.Forms.GroupBox gbVerInfoGrupos;
        private System.Windows.Forms.DataGridView dgvListarGrupos;
        private System.Windows.Forms.Button btnListarGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadAlumnos;
    }
}
