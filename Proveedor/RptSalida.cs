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
    public partial class RptSalida : Form
    {
        int opc;
        int opc2;

        void ListarNroDoc()
        {

                SqlDataAdapter da = new SqlDataAdapter("ListarNroDocSalida'" + opc2 + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbComprobante.DataSource = dt;
                cmbComprobante.DisplayMember = "NroDoc";
                //cmbComprobante.ValueMember = "IdSubCategoria";
                da.Dispose();

        }

        public RptSalida()
        {
            InitializeComponent();
        }


        private void rbfechas_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            cmbComprobante.Enabled = false;
            dtpfin.Enabled = true;
            dtpinicio.Enabled = true;
            cmbComprobante.Text = "";
            cmbtipodoc.SelectedIndex = -1;
        }

        private void rbComprobante_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            cmbComprobante.Enabled = true;
            dtpfin.Enabled = false;
            dtpinicio.Enabled = false;
            ListarNroDoc();
        }

        private void RptSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet10.Sp_RptSalida' Puede moverla o quitarla según sea necesario.
            this.Sp_RptSalidaTableAdapter.Fill(this.DBSYSCONDataSet10.Sp_RptSalida, cmbComprobante.Text, cmbtipodoc.Text, Convert.ToByte(opc), dtpinicio.Value, dtpfin.Value);

            this.reportViewer1.RefreshReport();
            cmbComprobante.Enabled = false;
            dtpfin.Enabled = true;
            dtpinicio.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Sp_RptSalidaTableAdapter.Fill(this.DBSYSCONDataSet10.Sp_RptSalida, cmbComprobante.Text, cmbtipodoc.Text, Convert.ToByte(opc), dtpinicio.Value, dtpfin.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbtipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipodoc.SelectedIndex== 0) {
                opc2 = 1;
                ListarNroDoc();
            }
            else if(cmbtipodoc.SelectedIndex == 1) {
                opc2 = 2;
                ListarNroDoc();
            }
            else if(cmbtipodoc.SelectedIndex == 2) {
                opc2 = 3;
                ListarNroDoc();
            }
            else if(cmbtipodoc.SelectedIndex == 3) {
                opc2 = 4;
                ListarNroDoc();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
