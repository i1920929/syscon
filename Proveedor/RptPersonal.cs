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
    public partial class RptPersonal : Form
    {
        public RptPersonal()
        {
            InitializeComponent();
        }

        private void RptPersonal_Load(object sender, EventArgs e)
        {
            try
            {// TODO: esta línea de código carga datos en la tabla 'DBSYSCONDataSet2.Sp_ListarPersonal' Puede moverla o quitarla según sea necesario.
                this.Sp_ListarPersonalTableAdapter.Fill(this.DBSYSCONDataSet2.Sp_ListarPersonal);

                this.reportViewer1.RefreshReport();
            }
            catch { }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sp_ListarPersonalTableAdapter.Fill(this.DBSYSCONDataSet2.Sp_ListarPersonal);

                this.reportViewer1.RefreshReport();
            }
            catch { }
        }

        private void Sp_ListarPersonalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
