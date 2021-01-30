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
    public partial class frmPrincipal : Form
    {
        public void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarBusqueda", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBusqueda.DataSource = dt;
            da.Dispose();
            
        }
        int opc;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null)
            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelcontenedor.Controls.Add(childForm);
                panelcontenedor.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmPersonal());
            cargartabla();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmProveedor());
            //Form f1 = new frmProveedor();
            //f1.MdiParent= this ;
            //f1.Show();
            //f1.WindowState = FormWindowState.Maximized; 
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargartabla();
            if (SYSCON.nivelseg == "OPERARIO")
            {
                this.toolStripButton1.Enabled = false;
                this.toolStripButton2.Enabled = false;
                this.toolStripButton3.Enabled = false;

            }
            lblnomuser.Text = SYSCON.nombreuser;
            lblcargo.Text = SYSCON.nivelseg;
           
        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProducto());
            cargartabla();

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void verUbicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalida());
            cargartabla();
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategoria());
            cargartabla();
        }

        private void subCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSubCategoria());
            cargartabla();
        }

        private void uNIDADDEMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUnidadMedida());
            cargartabla();
        }

        private void uBICACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUbicacion());
            cargartabla();
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            txtBuscar.Clear();
            cargartabla();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            txtBuscar.Clear();
            cargartabla();
        }

        private void rdbSubcategoria_CheckedChanged(object sender, EventArgs e)
        {
            opc = 2;
            txtBuscar.Clear();
            cargartabla();
        }

        public void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_BuscarProducto '" + txtBuscar.Text + "','" + opc + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBusqueda.DataSource = dt;
                da.Dispose();
            }
            catch
            {
             
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReportes());
            cargartabla();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("¿Estas seguro de cerrar sesión?", "Consulta" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmAcceso f1 = new frmAcceso();
                f1.Visible = true;
                Visible = false;                
            }
            else {
                e.Cancel=true;

            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            opc = 3;
            txtBuscar.Clear();
            
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDevolucion());
            cargartabla();
        }

        private void registroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmEntrada());
            cargartabla();
        }

        private void devoluciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalida());
            cargartabla();
        }
    }
}
