﻿namespace consulta_nomina
{
    partial class frmBusquedaCargo
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
            this.dgvcargo = new System.Windows.Forms.DataGridView();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnCargo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcargo
            // 
            this.dgvcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcargo.Location = new System.Drawing.Point(16, 121);
            this.dgvcargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvcargo.Name = "dgvcargo";
            this.dgvcargo.Size = new System.Drawing.Size(556, 185);
            this.dgvcargo.TabIndex = 0;
            this.dgvcargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargo_CellContentClick);
            this.dgvcargo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargo_CellDoubleClick);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(27, 23);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(42, 21);
            this.rbtnId.TabIndex = 1;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnCargo
            // 
            this.rbtnCargo.AutoSize = true;
            this.rbtnCargo.Location = new System.Drawing.Point(27, 52);
            this.rbtnCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCargo.Name = "rbtnCargo";
            this.rbtnCargo.Size = new System.Drawing.Size(67, 21);
            this.rbtnCargo.TabIndex = 2;
            this.rbtnCargo.TabStop = true;
            this.rbtnCargo.Text = "Cargo";
            this.rbtnCargo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnId);
            this.groupBox1.Controls.Add(this.rbtnCargo);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(159, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(504, 20);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(68, 54);
            this.btncrear.TabIndex = 18;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(423, 20);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(76, 54);
            this.btnimprimir.TabIndex = 17;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(333, 21);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(84, 54);
            this.bntBuscar.TabIndex = 16;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(193, 37);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmBusquedaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 320);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvcargo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBusquedaCargo";
            this.Text = "frmBusquedaCargo";
            this.Load += new System.EventHandler(this.frmBusquedaCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcargo;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.RadioButton rbtnCargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}