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
using System.Globalization;

namespace Proveedor
{
    public partial class frmProducto : Form
    {
        int opc;
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarProducto", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvproducto.DataSource = dt;
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
        void rellenaunidadmedida()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarUnidadMedida", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbunidadmedida.DataSource = dt;
            cmbunidadmedida.DisplayMember = "Simbolo";
            cmbunidadmedida.ValueMember = "IdUnidadMedida";
            da.Dispose();
        }
        void rellenasubcat()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select* from SubCategoria where IdCategoria='" + cmbcategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbsubcategoria.DataSource = dt;
                cmbsubcategoria.DisplayMember = "Nombre_SubCategoria";
                cmbsubcategoria.ValueMember = "IdSubCategoria";
                da.Dispose();
            }
            catch { }
                    
        }
        public frmProducto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            rellenacombo();
            cargartabla();
            rellenaunidadmedida();
            rellenasubcat();
            dgvproducto.Columns[6].Visible=false;
            dgvproducto.Columns[11].Visible = false;
            dgvproducto.Columns[12].Visible = false;

        }

        public void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtcodigo.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[0].Value);
                txtnombre.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[1].Value);
                nudpreciov.Text= Convert.ToString(dgvproducto.CurrentRow.Cells[2].Value);
                nudprecioc.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[3].Value);
                cmbcategoria.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[4].Value);
                cmbsubcategoria.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[5].Value);
                txtmarca.Text = Convert.ToString(dgvproducto.CurrentRow.Cells[7].Value);
                nudstockactual.Value = Convert.ToInt32(dgvproducto.CurrentRow.Cells[8].Value);
                nudstockmin.Value = Convert.ToInt32(dgvproducto.CurrentRow.Cells[9].Value);
                cmbunidadmedida.SelectedValue = Convert.ToString(dgvproducto.CurrentRow.Cells[11].Value);
                
             
                

            }
            catch 
            {
            } 
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || nudstockmin.Value == 0 || txtmarca.Text == "" || cmbcategoria.Text == "" || cmbsubcategoria.Text == "" || cmbunidadmedida.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
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

                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarProducto '" + txtcodigo.Text + "','" + txtnombre.Text + "','" +  Convert.ToDouble(nudpreciov.Value) + "','" + Convert.ToInt32(cmbcategoria.SelectedValue) + "','" + txtmarca.Text.ToUpper() + "','" + Convert.ToInt32(nudstockactual.Value) + "','" + Convert.ToInt32(cmbunidadmedida.SelectedValue) + "','" + Convert.ToInt32(cmbsubcategoria.SelectedValue) + "','" + Convert.ToInt32(nudstockmin.Value) + "','" + Convert.ToDouble(nudprecioc.Value) + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se actualizó registro");
                    }
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            nudprecioc.Enabled = true;
            nudpreciov.Enabled = true;
            dgvproducto.Enabled = true;
            if (txtnombre.Text == "" || nudstockmin.Value == 0 || txtmarca.Text == "" || cmbcategoria.Text == "" || cmbsubcategoria.Text == "" || cmbunidadmedida.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                nudprecioc.Enabled = false;
                nudpreciov.Enabled = false;
            }

            else
            {
                nudprecioc.Enabled = false;
                nudpreciov.Enabled = false;
                if (MessageBox.Show("¿Estas seguro de agregar?", "advertencia",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        string nombre;
                        nombre = Convert.ToString(txtnombre.Text + "  " + txtmarca.Text).ToUpper();
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarProducto '" + nombre + "','" + Convert.ToDecimal(nudpreciov.Value) + "','" + Convert.ToInt32(cmbcategoria.SelectedValue) + "','" + txtmarca.Text.ToUpper() + "','" + Convert.ToInt32(nudstockactual.Value) + "','" + Convert.ToInt32(cmbunidadmedida.SelectedValue) + "','" + Convert.ToInt32(cmbsubcategoria.SelectedValue) + "','" + Convert.ToInt32(nudstockmin.Value) + "','" + Convert.ToDouble(nudprecioc.Value) + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        cargartabla();
                        nudprecioc.Enabled = true;
                        nudpreciov.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }

            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nudprecioc.Enabled = false;
            nudpreciov.Enabled = false;
            SYSCON.limpiar(this.groupBox2);
            txtnombre.Select();
            nudstockactual.Value = Convert.ToInt32(0);
            nudpreciov.Value = Convert.ToDecimal(0);
            dgvproducto.Enabled = false;
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            byte x;
            x = Convert.ToByte(MessageBox.Show("¿Está seguro de salir de la pestaña REGISTRO PRODUCTO?",
                "Advertencia...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question));

            if (x == 6)
            {
                this.Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select* from SubCategoria where IdCategoria='" + cmbcategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbsubcategoria.DataSource = dt;
                cmbsubcategoria.DisplayMember = "Nombre_SubCategoria";
                cmbsubcategoria.ValueMember = "IdSubCategoria";
                da.Dispose();
            }

            catch { }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            opc = 0;
            txtBuscar.Clear();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            opc = 1;
            txtBuscar.Clear();
        }

        private void rdbSubcategoria_CheckedChanged(object sender, EventArgs e)
        {
            opc = 2;
            txtBuscar.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_BuscarProd '" + txtBuscar.Text + "','" + opc + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvproducto.DataSource = dt;
                da.Dispose();
                
            }
            catch
            {

            }
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
