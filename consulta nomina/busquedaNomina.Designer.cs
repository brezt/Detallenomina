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
            this.rbtncedula = new System.Windows.Forms.RadioButton();
            this.rbtnapellido = new System.Windows.Forms.RadioButton();
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(1051, 10);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(71, 66);
            this.btncrear.TabIndex = 15;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(949, 11);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(71, 66);
            this.btnimprimir.TabIndex = 14;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(823, 11);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(97, 66);
            this.bntBuscar.TabIndex = 13;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(395, 33);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(409, 22);
            this.txtbuscar.TabIndex = 12;
            // 
            // rbtncedula
            // 
            this.rbtncedula.AutoSize = true;
            this.rbtncedula.Location = new System.Drawing.Point(300, 33);
            this.rbtncedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtncedula.Name = "rbtncedula";
            this.rbtncedula.Size = new System.Drawing.Size(73, 21);
            this.rbtncedula.TabIndex = 11;
            this.rbtncedula.TabStop = true;
            this.rbtncedula.Text = "Cédula";
            this.rbtncedula.UseVisualStyleBackColor = true;
            // 
            // rbtnapellido
            // 
            this.rbtnapellido.AutoSize = true;
            this.rbtnapellido.Location = new System.Drawing.Point(193, 33);
            this.rbtnapellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnapellido.Name = "rbtnapellido";
            this.rbtnapellido.Size = new System.Drawing.Size(79, 21);
            this.rbtnapellido.TabIndex = 10;
            this.rbtnapellido.TabStop = true;
            this.rbtnapellido.Text = "Apellido";
            this.rbtnapellido.UseVisualStyleBackColor = true;
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSize = true;
            this.rbtnid.Location = new System.Drawing.Point(80, 34);
            this.rbtnid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.Size = new System.Drawing.Size(68, 21);
            this.rbtnid.TabIndex = 8;
            this.rbtnid.TabStop = true;
            this.rbtnid.Text = "Fecha";
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // busquedaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 630);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rbtncedula);
            this.Controls.Add(this.rbtnapellido);
            this.Controls.Add(this.rbtnid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "busquedaNomina";
            this.Text = "busquedaNomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rbtncedula;
        private System.Windows.Forms.RadioButton rbtnapellido;
        private System.Windows.Forms.RadioButton rbtnid;
    }
}