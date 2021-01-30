using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proveedor
{
    public partial class frmImpresionSalida : Form
    {
        public frmImpresionSalida()
        {
            InitializeComponent();
        }

        private void frmImpresionSalida_Load(object sender, EventArgs e)
        {
            int idsalida;

            SqlDataAdapter da = new SqlDataAdapter("Sp_ultimoidsalida", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            idsalida = Convert.ToInt32(dt.Rows[0]["IdSalida"]);
            da.Dispose();

            // TODO: This line of code loads data into the 'DBSYSCONDataSet16.Sp_Imprimir' table. You can move, or remove it, as needed.
            this.Sp_ImprimirTableAdapter.Fill(this.DBSYSCONDataSet16.Sp_Imprimir,idsalida);
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
