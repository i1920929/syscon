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
    public partial class frmRptKardex : Form
    {
        int opc = 0;
        public frmRptKardex()
        {
            InitializeComponent();
        }

        private void frmRptKardex_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet22.Sp_RptKardex' Puede moverla o quitarla según sea necesario.
            //this.Sp_RptKardexTableAdapter.Fill(this.DBSYSCONDataSet22.Sp_RptKardex);

        }

        private void rbComprobante_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            txtnom.Enabled = false;
        }

        private void rbfechas_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            txtnom.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Sp_RptKardexTableAdapter.Fill(this.DBSYSCONDataSet22.Sp_RptKardex,txtnom.Text,opc,dtpinicio.Value,dtpfin.Value);
            this.reportViewer2.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
