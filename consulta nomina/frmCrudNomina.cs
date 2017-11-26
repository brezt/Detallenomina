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
    public partial class frmCrudNomina : Form
    {
        public frmCrudNomina()
        {
            InitializeComponent();
        }

        private void frmCrudNomina_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            Operaciones op = new Operaciones();
           dgvDetalleNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo=cargo.idcargo");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < dgvDetalleNomina.Rows.Count; a++)
            {
                float isr = 0;
                float ss=0; 
                float otros = 0;
                float neto=0;
                float sueldo=0;
                int idEmpleado=0;
                isr = float.Parse(dgvDetalleNomina.Rows[a].Cells["ISR"].Value.ToString());
                ss = float.Parse(dgvDetalleNomina.Rows[a].Cells["SS"].Value.ToString());
                otros= float.Parse(dgvDetalleNomina.Rows[a].Cells["Ahorros"].Value.ToString());
                sueldo = float.Parse(dgvDetalleNomina.Rows[a].Cells["sueldoempleado"].Value.ToString());
                idEmpleado= Convert.ToInt32(dgvDetalleNomina.Rows[a].Cells["idempleado"].Value.ToString());
                neto =  float.Parse(dgvDetalleNomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());




                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into Detalle_nomina (idempledo, sueldoempleado, isr, ss, otrosdescuentos, neto) values( '"+idEmpleado+"','"+sueldo+"', '"+isr+"', '"+ss+"', '"+otros+"', '"+neto+"')");
                


            }
            MessageBox.Show("DATOS GUARDADOS");
        }
    }
}
