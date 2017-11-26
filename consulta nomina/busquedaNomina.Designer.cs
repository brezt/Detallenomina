namespace consulta_nomina
{
    partial class busquedaNomina
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
            this.btncrear = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.rbtnStatus = new System.Windows.Forms.RadioButton();
            this.rbtnNumero = new System.Windows.Forms.RadioButton();
            this.tbtnFecha = new System.Windows.Forms.RadioButton();
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.dgvDetalleNomina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(788, 8);
            this.btncrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(53, 54);
            this.btncrear.TabIndex = 15;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(712, 9);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(53, 54);
            this.btnimprimir.TabIndex = 14;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(617, 9);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(73, 54);
            this.bntBuscar.TabIndex = 13;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(296, 27);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(308, 20);
            this.txtbuscar.TabIndex = 12;
            // 
            // rbtnStatus
            // 
            this.rbtnStatus.AutoSize = true;
            this.rbtnStatus.Location = new System.Drawing.Point(225, 27);
            this.rbtnStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnStatus.Name = "rbtnStatus";
            this.rbtnStatus.Size = new System.Drawing.Size(55, 17);
            this.rbtnStatus.TabIndex = 11;
            this.rbtnStatus.TabStop = true;
            this.rbtnStatus.Text = "Status";
            this.rbtnStatus.UseVisualStyleBackColor = true;
            // 
            // rbtnNumero
            // 
            this.rbtnNumero.AutoSize = true;
            this.rbtnNumero.Location = new System.Drawing.Point(145, 27);
            this.rbtnNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnNumero.Name = "rbtnNumero";
            this.rbtnNumero.Size = new System.Drawing.Size(60, 17);
            this.rbtnNumero.TabIndex = 10;
            this.rbtnNumero.TabStop = true;
            this.rbtnNumero.Text = "numero";
            this.rbtnNumero.UseVisualStyleBackColor = true;
            // 
            // tbtnFecha
            // 
            this.tbtnFecha.AutoSize = true;
            this.tbtnFecha.Location = new System.Drawing.Point(60, 28);
            this.tbtnFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtnFecha.Name = "tbtnFecha";
            this.tbtnFecha.Size = new System.Drawing.Size(55, 17);
            this.tbtnFecha.TabIndex = 8;
            this.tbtnFecha.TabStop = true;
            this.tbtnFecha.Text = "Fecha";
            this.tbtnFecha.UseVisualStyleBackColor = true;
            // 
            // dgvNomina
            // 
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(24, 82);
            this.dgvNomina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.RowTemplate.Height = 24;
            this.dgvNomina.Size = new System.Drawing.Size(898, 158);
            this.dgvNomina.TabIndex = 16;
            // 
            // dgvDetalleNomina
            // 
            this.dgvDetalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleNomina.Location = new System.Drawing.Point(24, 273);
            this.dgvDetalleNomina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetalleNomina.Name = "dgvDetalleNomina";
            this.dgvDetalleNomina.RowTemplate.Height = 24;
            this.dgvDetalleNomina.Size = new System.Drawing.Size(898, 158);
            this.dgvDetalleNomina.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Maestro Nomina -Detalle Nomina";
            // 
            // busquedaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleNomina);
            this.Controls.Add(this.dgvNomina);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rbtnStatus);
            this.Controls.Add(this.rbtnNumero);
            this.Controls.Add(this.tbtnFecha);
            this.Name = "busquedaNomina";
            this.Text = "busquedaNomina";
            this.Load += new System.EventHandler(this.busquedaNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rbtnStatus;
        private System.Windows.Forms.RadioButton rbtnNumero;
        private System.Windows.Forms.RadioButton tbtnFecha;
        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.DataGridView dgvDetalleNomina;
        private System.Windows.Forms.Label label1;
    }
}