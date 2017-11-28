namespace consulta_nomina
{
    partial class frmCrudNomina
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHasta = new System.Windows.Forms.DateTimePicker();
            this.txtDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarNomina = new System.Windows.Forms.Button();
            this.dgvDetalleNomina = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDeducciones = new System.Windows.Forms.TextBox();
            this.txtTotalNomina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNumeroNomina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Semanal",
            "Quinsenal",
            "Mensual",
            "Doble Sueldo",
            "Incentivo"});
            this.cmbTipo.Location = new System.Drawing.Point(69, 31);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Proceso",
            "Cerrada"});
            this.cmbStatus.Location = new System.Drawing.Point(308, 28);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtHasta
            // 
            this.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHasta.Location = new System.Drawing.Point(252, 20);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(107, 22);
            this.txtHasta.TabIndex = 3;
            this.txtHasta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtDesde
            // 
            this.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDesde.Location = new System.Drawing.Point(75, 20);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(107, 22);
            this.txtDesde.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde";
            // 
            // btnGenerarNomina
            // 
            this.btnGenerarNomina.Location = new System.Drawing.Point(916, 25);
            this.btnGenerarNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarNomina.Name = "btnGenerarNomina";
            this.btnGenerarNomina.Size = new System.Drawing.Size(147, 23);
            this.btnGenerarNomina.TabIndex = 0;
            this.btnGenerarNomina.Text = "Generar Nómina";
            this.btnGenerarNomina.UseVisualStyleBackColor = true;
            this.btnGenerarNomina.Click += new System.EventHandler(this.btnGenerarNomina_Click);
            // 
            // dgvDetalleNomina
            // 
            this.dgvDetalleNomina.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleNomina.Location = new System.Drawing.Point(31, 119);
            this.dgvDetalleNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalleNomina.Name = "dgvDetalleNomina";
            this.dgvDetalleNomina.RowTemplate.Height = 24;
            this.dgvDetalleNomina.Size = new System.Drawing.Size(1064, 314);
            this.dgvDetalleNomina.TabIndex = 6;
            this.dgvDetalleNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleNomina_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(175, 460);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 57);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(341, 460);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(147, 57);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Deducciones";
            // 
            // txtTotalDeducciones
            // 
            this.txtTotalDeducciones.Location = new System.Drawing.Point(661, 478);
            this.txtTotalDeducciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalDeducciones.Name = "txtTotalDeducciones";
            this.txtTotalDeducciones.ReadOnly = true;
            this.txtTotalDeducciones.Size = new System.Drawing.Size(145, 22);
            this.txtTotalDeducciones.TabIndex = 10;
            this.txtTotalDeducciones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTotalNomina
            // 
            this.txtTotalNomina.Location = new System.Drawing.Point(932, 478);
            this.txtTotalNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalNomina.Name = "txtTotalNomina";
            this.txtTotalNomina.ReadOnly = true;
            this.txtTotalNomina.Size = new System.Drawing.Size(145, 22);
            this.txtTotalNomina.TabIndex = 12;
            this.txtTotalNomina.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Nomina";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(12, 460);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(147, 57);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNumeroNomina
            // 
            this.txtNumeroNomina.Location = new System.Drawing.Point(164, 90);
            this.txtNumeroNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroNomina.Name = "txtNumeroNomina";
            this.txtNumeroNomina.Size = new System.Drawing.Size(63, 22);
            this.txtNumeroNomina.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número de Nómina";
            // 
            // frmCrudNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroNomina);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtTotalNomina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalDeducciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDetalleNomina);
            this.Controls.Add(this.btnGenerarNomina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCrudNomina";
            this.Text = "frmCrudNomina";
            this.Load += new System.EventHandler(this.frmCrudNomina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetalleNomina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDeducciones;
        private System.Windows.Forms.TextBox txtTotalNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox cmbTipo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbStatus;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnGenerarNomina;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.TextBox txtNumeroNomina;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker txtHasta;
        public System.Windows.Forms.DateTimePicker txtDesde;
    }
}