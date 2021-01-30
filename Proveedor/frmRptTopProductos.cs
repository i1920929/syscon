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
    public partial class frmRptTopProductos : Form
    {
        int opc=1;
        public frmRptTopProductos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRptTopProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet19.Sp_RptTopProductos' Puede moverla o quitarla según sea necesario.
           // this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos);
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet19.Sp_RptTopProductos' Puede moverla o quitarla según sea necesario.
            //this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos);

        }

        private void rbfechas_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            reportViewer1.Visible = true;
            reportViewer2.Visible = false;
            try
            {
                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer1.RefreshReport();

                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer2.RefreshReport();
            }
            catch { }
        }

        private void rbComprobante_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            reportViewer2.Visible = true;
            reportViewer1.Visible = false;
            try
            {
                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer1.RefreshReport();

                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer2.RefreshReport();
            }
            catch { }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer1.RefreshReport();

                this.Sp_RptTopProductosTableAdapter.Fill(this.DBSYSCONDataSet19.Sp_RptTopProductos, opc, dtpinicio.Value, dtpfin.Value);
                this.reportViewer2.RefreshReport();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
