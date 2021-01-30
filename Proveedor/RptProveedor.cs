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
    public partial class RptProveedor : Form
    {
        public RptProveedor()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RptProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet3.Sp_ListarProveedor' Puede moverla o quitarla según sea necesario.
            this.Sp_ListarProveedorTableAdapter.Fill(this.DBSYSCONDataSet3.Sp_ListarProveedor);

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
