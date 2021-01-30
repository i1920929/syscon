using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proveedor
{
   

    public partial class frmRptProducto : Form
    {
        int opc;
        public frmRptProducto()
        {
            InitializeComponent();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRptProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet1.Sp_RptProducto' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet.Sp_ListarProducto' Puede moverla o quitarla según sea necesario.
            opc = 0;
            rbTodo.Checked = true;
            txtcad.Enabled = false;
            try
            {
                this.Sp_RptProductoTableAdapter.Fill(this.DBSYSCONDataSet1.Sp_RptProducto, txtcad.Text, Convert.ToByte(opc));
                this.reportViewer1.RefreshReport();
                rbTodo.Checked = true;
                txtcad.Enabled = false;
            }
            catch
            { 
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            txtcad.Enabled = false;
            txtcad.Clear();
        }
        private void rbCateg_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            txtcad.Enabled = true;
            txtcad.Clear();
        }

        private void rbSubcat_CheckedChanged(object sender, EventArgs e)
        {
            opc = 2;
            txtcad.Enabled = true;
            txtcad.Clear();
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            opc = 3;
            txtcad.Enabled = false;
            txtcad.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sp_RptProductoTableAdapter.Fill(this.DBSYSCONDataSet1.Sp_RptProducto,txtcad.Text,Convert.ToByte(opc));

            this.reportViewer1.RefreshReport();
        }

        private void txtcad_TextChanged(object sender, EventArgs e)
        {
            this.Sp_RptProductoTableAdapter.Fill(this.DBSYSCONDataSet1.Sp_RptProducto, txtcad.Text, Convert.ToByte(opc));

            this.reportViewer1.RefreshReport();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
