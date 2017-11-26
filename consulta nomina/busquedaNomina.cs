using System;
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
            dgvNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo=cargo.idcargo");


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

    }
}
