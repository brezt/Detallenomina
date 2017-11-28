﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consulta_nomina
{
    public partial class busquedaNomina : Form
    {
        public busquedaNomina()
        {
            InitializeComponent();
        }

        private void busquedaNomina_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            dgvNomina.DataSource = op.ConsultaConResultado("select *from cabecera_nomina ");


        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            /* if (rbtnNumero.Checked == true)
             {
                 Operaciones op = new Operaciones();
               dgvNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo like '%" + txtbuscar.Text + "%'");
             }

            else if (rbtnNumero.Checked == true)
             {
                 Operaciones op = new Operaciones();
                 dgvNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo like '%" + txtbuscar.Text + "%'");
             }

             else if (rbtnStatus.Checked == true)
             {
                 Operaciones op = new Operaciones();
                 dgvNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo like '%" + txtbuscar.Text + "%'");
             }
             */
        }


   

        private void btncrear_Click(object sender, EventArgs e)
        {

            frmCrudNomina cn = new frmCrudNomina();
          
            cn.Show();
        }

        private void dgvNomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvDetalleNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNomina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones op = new Operaciones();
            DataGridViewRow rellenar = dgvNomina.Rows[e.RowIndex];
            string numero;
            numero = rellenar.Cells["codigonomina"].Value.ToString();

            dgvDetalleNomina.DataSource = op.ConsultaConResultado("select detalle_nomina.codnomina, empleados.nombreempleado, detalle_nomina.sueldoempleado, detalle_nomina.isr, detalle_nomina.ss, detalle_nomina.otrosdescuentos, detalle_nomina.neto from detalle_nomina inner join cabecera_nomina on detalle_nomina.codnomina = cabecera_nomina.codigonomina  inner join empleados on empleados.idempleado = detalle_nomina.idempledo");

         
        }

        private void dgvNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCrudNomina cn = new frmCrudNomina();
            DataGridViewRow rellenar = dgvDetalleNomina.Rows[e.RowIndex];

            re
        }
    }
}
