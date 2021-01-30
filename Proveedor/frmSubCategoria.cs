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
    public partial class frmSubCategoria : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarSubCategoria", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dbgsubcategoria.DataSource = dt;
            da.Dispose();

        }
        void rellenacombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarCategoria", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbcategoria.DataSource = dt;
            cmbcategoria.DisplayMember = "Nombre_Categoria";
            cmbcategoria.ValueMember = "IdCategoria";
            da.Dispose();
        }
        public frmSubCategoria()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            txtnombre.Select();
            dbgsubcategoria.Enabled = false;
        }

        private void dbgsubcategoria_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtcodigo.Text = Convert.ToString(dbgsubcategoria.CurrentRow.Cells[0].Value);
                txtnombre.Text = Convert.ToString(dbgsubcategoria.CurrentRow.Cells[1].Value);
                cmbcategoria.Text = Convert.ToString(dbgsubcategoria.CurrentRow.Cells[2].Value);
            }
            catch
            {
            } 
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            dbgsubcategoria.Enabled = true;
            if (txtnombre.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtnombre.Focus();
            }

            else if (cmbcategoria.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                cmbcategoria.Focus();
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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarSubCategoria '" + txtnombre.Text.ToUpper() + "','" + Convert.ToInt32(cmbcategoria.SelectedValue) + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                        rellenacombo();
                       
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtnombre.Focus();
            }

            else if (cmbcategoria.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                cmbcategoria.Focus();
            }
            else
            {
                if (MessageBox.Show("¿Estas seguro de actualizar?", "advertencia",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarSubCategoria '" + txtcodigo.Text.ToUpper() + "','" + txtnombre.Text.ToUpper() + "','" + Convert.ToInt32(cmbcategoria.SelectedValue) + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                        rellenacombo();

                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }
            }
        }

        private void frmSubCategoria_Load(object sender, EventArgs e)
        {
            cargartabla();
            rellenacombo();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

    }
}
