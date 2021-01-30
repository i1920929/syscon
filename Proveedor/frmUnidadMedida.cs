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
    public partial class frmUnidadMedida : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarUnidadMedida", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvunidadmedida.DataSource = dt;
            da.Dispose();

        }
        public frmUnidadMedida()
        {
            InitializeComponent();
        }

        private void frmUnidadMedida_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtcodmedida.Text = Convert.ToString(dgvunidadmedida.CurrentRow.Cells[0].Value);
                txtnombre.Text = Convert.ToString(dgvunidadmedida.CurrentRow.Cells[1].Value);
                txtsimbolo.Text = Convert.ToString(dgvunidadmedida.CurrentRow.Cells[2].Value);

            }
            catch
            {
            } 
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgvunidadmedida.Enabled = true;
            if (txtnombre.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtnombre.Focus();
            }
            else if (txtsimbolo.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtsimbolo.Focus();
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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarUnidadMedida '" + txtnombre.Text.ToUpper() + "','" + txtsimbolo.Text + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                       
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se insertó registro");
                    }
                }

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtnombre.Focus();
            }
            else if (txtsimbolo.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtsimbolo.Focus();
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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarUnidadMedida '" + txtcodmedida.Text + "','" + txtnombre.Text.ToUpper() + "','" + txtsimbolo.Text + "'", SYSCON.cadconex);
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
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            txtnombre.Select();
            dgvunidadmedida.Enabled=false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }
    }
}
