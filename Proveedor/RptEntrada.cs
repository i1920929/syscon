using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proveedor
{
    public partial class RptEntrada : Form
    {
        int opc;
        public RptEntrada()
        {
            InitializeComponent();
        }
        void ListarNroDoc()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("ListarNroDocEntrada", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbComprobante.DataSource = dt;
                cmbComprobante.DisplayMember = "NroDoc";
                //cmbComprobante.ValueMember = "IdSubCategoria";
                da.Dispose();
            }

            catch { }
        }

        private void RptEntrada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet8.Sp_RptEntrada' Puede moverla o quitarla según sea necesario.
            this.Sp_RptEntradaTableAdapter.Fill(this.DBSYSCONDataSet8.Sp_RptEntrada, cmbComprobante.Text, Convert.ToByte(opc), dtpinicio.Value, dtpfin.Value);

            this.reportViewer1.RefreshReport();
            cmbComprobante.Enabled = false;
            dtpfin.Enabled = true;
            dtpinicio.Enabled = true;
        }

        private void rbfechas_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            cmbComprobante.Enabled = false;
            dtpfin.Enabled = true;
            dtpinicio.Enabled = true;
            cmbComprobante.Text = "";

        }

        private void rbNumDoc_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            cmbComprobante.Enabled = true;
            dtpfin.Enabled = false;
            dtpinicio.Enabled = false;
            ListarNroDoc();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Sp_RptEntradaTableAdapter.Fill(this.DBSYSCONDataSet8.Sp_RptEntrada,cmbComprobante.Text,Convert.ToByte(opc),dtpinicio.Value,dtpfin.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
