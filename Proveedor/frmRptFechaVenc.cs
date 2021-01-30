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
    public partial class frmRptFechaVenc : Form
    {
        public frmRptFechaVenc()
        {
            InitializeComponent();
        }

        int opc=0;
        private void frmRptFechaVenc_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet18.Sp_RptFechaVenc' Puede moverla o quitarla según sea necesario.
           // this.Sp_RptFechaVencTableAdapter.Fill(this.DBSYSCONDataSet18.Sp_RptFechaVenc);

        }

        private void rbTodo_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
        }

        private void rbCateg_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sp_RptFechaVencTableAdapter.Fill(this.DBSYSCONDataSet18.Sp_RptFechaVenc, Convert.ToByte(opc));
            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
