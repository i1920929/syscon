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
    public partial class frmCategoria : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarCategoria", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dbgLista.DataSource = dt;
            da.Dispose();

        }
        void rellenacombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarUbicacion", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUbicacion.DataSource = dt;
            cmbUbicacion.DisplayMember = "Descripcion";
            cmbUbicacion.ValueMember = "IdUbicacion";
            da.Dispose();
        }
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargartabla();
            rellenacombo();
        }

        private void dbgLista_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            txtcodcat.Text = Convert.ToString(dbgLista.CurrentRow.Cells[0].Value);
            txtNomCat.Text = Convert.ToString(dbgLista.CurrentRow.Cells[1].Value);
            txtdescripcion.Text = Convert.ToString(dbgLista.CurrentRow.Cells[2].Value);
            cmbUbicacion.Text = Convert.ToString(dbgLista.CurrentRow.Cells[3].Value);
            }
            catch
            {
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            txtNomCat.Select();
            dbgLista.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dbgLista.Enabled = true;
            if (txtNomCat.Text == "" || cmbUbicacion.Text == "" || txtdescripcion.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else
            {
                if (MessageBox.Show("¿Estas seguro de agregar?", "advertencia",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarCategoria '" + txtNomCat.Text.ToUpper() + "','" + txtdescripcion.Text.ToUpper() + "','" + Convert.ToInt32(cmbUbicacion.SelectedValue) + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                   
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de actualizar?", "advertencia",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarCategoria '" + txtcodcat.Text + "','" + txtNomCat.Text.ToUpper() + "','" + txtdescripcion.Text.ToUpper() + "','" + Convert.ToInt32(cmbUbicacion.SelectedValue) + "'", SYSCON.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    cargartabla();
                    
                }
                catch
                {
                    MessageBox.Show("Error, no se actualizo registro");
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }
    }
}
