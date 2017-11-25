namespace consulta_nomina
{
    partial class frmCargo
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
            this.txtdescriccion = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdescriccion
            // 
            this.txtdescriccion.Location = new System.Drawing.Point(81, 43);
            this.txtdescriccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescriccion.Name = "txtdescriccion";
            this.txtdescriccion.Size = new System.Drawing.Size(236, 20);
            this.txtdescriccion.TabIndex = 34;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AutoSize = true;
            this.txtdescripcion.Location = new System.Drawing.Point(11, 46);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(66, 13);
            this.txtdescripcion.TabIndex = 33;
            this.txtdescripcion.Text = "Descripción:";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(264, 97);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(56, 19);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(183, 97);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(56, 19);
            this.btnimprimir.TabIndex = 37;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(101, 97);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 19);
            this.btnguardar.TabIndex = 36;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(19, 97);
            this.btncrear.Margin = new System.Windows.Forms.Padding(2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(56, 19);
            this.btncrear.TabIndex = 35;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 11);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(59, 20);
            this.txtId.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 138);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtdescriccion);
            this.Controls.Add(this.txtdescripcion);
            this.Name = "frmCargo";
            this.Text = "frmCargo";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtdescriccion;
        private System.Windows.Forms.Label txtdescripcion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}