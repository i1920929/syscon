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
    public partial class frmReportes : Form
    {
        private Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelcontenedor1.Controls.Add(childForm);
            panelcontenedor1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmRptProducto());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new RptProveedor());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new RptPersonal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new RptEntrada());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRptKardex());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRptFechaVenc());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new RptSalida());
        }

        private void btnrpttop_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRptTopProductos());
        }
    }
}
