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
    public partial class frmEntrada : Form
    {
        Int32 nvIdEntrada;
        int controlar = 0;
        bool estadofecha = true;
        void rellenacomboProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarProveedor", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbProveedor.DataSource = dt;
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            da.Dispose();
        }
        void rellenacomboCategoria()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarCategoria", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "Nombre_Categoria";
            cmbCategoria.ValueMember = "IdCategoria";
            da.Dispose();
        }
        
        void  actualstock(){
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Stock from Producto where IdProducto='" + txtCProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtStock.Text = Convert.ToString(dt.Rows[0]["Stock"]);
                da.Dispose();
            }
            catch
            {
            }
            }
        void listarproducto() {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from Producto where  IdSubCategoria='" + cmbSubCategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbProducto.DataSource = dt;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "IdProducto";
                da.Dispose();
            }
            catch { }

        }
        void rellenasubcat() {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select* from SubCategoria where IdCategoria='" + cmbCategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSubCategoria.DataSource = dt;
                cmbSubCategoria.DisplayMember = "Nombre_SubCategoria";
                cmbSubCategoria.ValueMember = "IdSubCategoria";
                da.Dispose();
            }

            catch { }
        }
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            cmbtipodoc.Focus();
            txtpersonal.Text = SYSCON.iduser;
            rellenacomboProveedor();
            rellenacomboCategoria();
            rellenasubcat();
            listarproducto();

            dgvEProducto.ColumnCount = 8;
            dgvEProducto.Columns[0].HeaderText = "IdProducto";
            dgvEProducto.Columns[1].HeaderText = "Producto";
            dgvEProducto.Columns[2].HeaderText = "Cantidad";
            dgvEProducto.Columns[3].HeaderText = "PrecioCosto";
            dgvEProducto.Columns[4].HeaderText = "PrecioVenta";
            dgvEProducto.Columns[5].HeaderText = "Lote";
            dgvEProducto.Columns[6].HeaderText = "FechaVenc";
            dgvEProducto.Columns[7].HeaderText = "FechaVencActivo";
            dgvEProducto.Columns[7].Visible = false;
        }

        
        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void txtPEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdProducto from Producto where Nombre='" + cmbProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtCProducto.Text = Convert.ToString(dt.Rows[0]["IdProducto"]);
                da.Dispose();
            }
            catch
            {
            }
        }
        private void txtCProducto_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PrecioVenta from Producto where IdProducto='" + txtCProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                nudpreciov.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                da.Dispose();
            }
            catch
            {
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PrecioCosto from Producto where IdProducto='" + txtCProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                nudprecioc.Text = Convert.ToString(dt.Rows[0]["PrecioCosto"]);
                da.Dispose();
            }
            catch
            {
            }
            actualstock();
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select StockMin from Producto where IdProducto='" + txtCProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtstockmin.Text = Convert.ToString(dt.Rows[0]["StockMin"]);
                da.Dispose();
            }
            catch
            {
            }
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select UnidadMedida.Simbolo from Producto INNER JOIN UnidadMedida ON UnidadMedida.IdUnidadMedida=Producto.IdUnidadMedida where IdProducto='" + txtCProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtUMedida.Text = Convert.ToString(dt.Rows[0]["Simbolo"]);
                da.Dispose();
            }
            catch
            {
            }

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //string repetido = txtCProducto.Text;
            actualstock();

            if (cmbtipodoc.Text == "" || txtNumeroDoc.Text == "" || cmbProveedor.Text == "" || txtpersonal.Text == "" || nudpreciov.Text == "" || nudprecioc.Text == "" || txtLote.Text == "" || cmbCategoria.Text == "" || cmbSubCategoria.Text == "" || cmbProducto.Text == ""|| nudCantidad.Value==0)
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else
            {
                if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //if (txtCProducto.Text == repetido) {

                    //    MessageBox.Show("No puede ingresar el mismo producto");

                    //}
                    //else {
                        //repetido = txtCProducto.Text;

                    //dgvEProducto.Rows.Add(txtCProducto.Text, cmbProducto.Text, nudCantidad.Value, nudprecioc.Value,nudpreciov.Value, txtLote.Text, dtpFechaVenc.Value.ToString("MM-dd-yyyy") );
                    //    SYSCON.limpiar(this.groupBox4);
                    //    SYSCON.limpiar(this.groupBox5);
                    //}


                        controlar = 0;
                        for (int i = 0; i <= dgvEProducto.RowCount - 1; i++)
                        {
                            int idpro;
                            idpro = Convert.ToInt32(dgvEProducto.Rows[i].Cells[0].Value);

                            if (Convert.ToInt32(txtCProducto.Text) == idpro)
                            {
                                dgvEProducto.Rows[i].Cells[2].Value = Convert.ToInt32(nudCantidad.Value) + Convert.ToInt32(dgvEProducto.Rows[i].Cells[2].Value);
                                SYSCON.limpiar(this.groupBox4);
                                SYSCON.limpiar(this.groupBox5); 
                                controlar++;
                                checkBox1.Checked = false;
                                dtpFechaVenc.Value = DateTime.Now;
                        }
                        }


                         if (controlar == 0)
                        {
                            dgvEProducto.Rows.Add(txtCProducto.Text, cmbProducto.Text, nudCantidad.Value, nudprecioc.Text, nudpreciov.Text, txtLote.Text.ToUpper(), dtpFechaVenc.Value.ToString("MM-dd-yyyy"),estadofecha);
                            SYSCON.limpiar(this.groupBox4);
                            SYSCON.limpiar(this.groupBox5);
                            checkBox1.Checked = false;
                            dtpFechaVenc.Value = DateTime.Now;
                    }

                }
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (dgvEProducto.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvEProducto.Rows.RemoveAt(dgvEProducto.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Aviso", MessageBoxButtons.YesNo);
                }
            }
        }

        private void btnREntradaP_Click_1(object sender, EventArgs e)
        {

            
           
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from Producto where  IdSubCategoria='" + cmbSubCategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbProducto.DataSource = dt;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "IdProducto";
                da.Dispose();
            }

            catch { }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select* from SubCategoria where IdCategoria='" + cmbCategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSubCategoria.DataSource = dt;
                cmbSubCategoria.DisplayMember = "Nombre_SubCategoria";
                cmbSubCategoria.ValueMember = "IdSubCategoria";
                da.Dispose();
            }

            catch { }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPEntrada_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEntrada_CurrentCellChanged(object sender, EventArgs e)
        {
         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            cmbtipodoc.Select();
            txtpersonal.Text = SYSCON.iduser;
        }

        

        private void txtTipoDoc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnREntradaP_Click(object sender, EventArgs e)
        {
            if (dgvEProducto.RowCount > 0)
            {
                if (MessageBox.Show("¿Estas seguro de registrar la entrada de productos?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarEntrada '" + cmbtipodoc.Text.ToUpper() + "','" + dtpEntrada.Value.ToString("MM-dd-yyyy") + "','" + SYSCON.iduser + "','" + cmbProveedor.SelectedValue + "','" + txtNumeroDoc.Text + "','"+""+"'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        //Se busca cabecera emitida en tabla docentrada 
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Entrada order by IdEntrada desc", SYSCON.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        nvIdEntrada = Convert.ToInt32(dt2.Rows[0]["IdEntrada"]);
                        da2.Dispose();
                        //Insertando Detalle de DocEntrada en la BD
                        int c;
                        for (c = 0; c <= dgvEProducto.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsertarProductoEntrada '" + nvIdEntrada + "','" + dgvEProducto.Rows[c].Cells[0].Value + "','" + dgvEProducto.Rows[c].Cells[2].Value + "','" + dgvEProducto.Rows[c].Cells[3].Value + "','" + dgvEProducto.Rows[c].Cells[5].Value + "','" + dgvEProducto.Rows[c].Cells[6].Value + "','" + dgvEProducto.Rows[c].Cells[4].Value + "','" + dgvEProducto.Rows[c].Cells[7].Value + "'", SYSCON.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();
                        }
                        MessageBox.Show("Ingreso procesado", "Aviso");
                        dgvEProducto.Rows.Clear();
                        txtCEntrada.Clear();
                        checkBox1.Checked = false;
                        txtCProducto.Clear();
                        nudCantidad.Value = 0;
                        cmbtipodoc.Focus();
                        cmbtipodoc.SelectedIndex = -1;
                        txtNumeroDoc.Clear();
                        dtpFechaVenc.Value = DateTime.Now;
                        //cmbtipodoc.Clear();
                        cmbProveedor.SelectedIndex = -1;
                        SYSCON.limpiar(this.groupBox4);
                        SYSCON.limpiar(this.groupBox5);


                    }
                    catch
                    {
                    }

                }
            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                estadofecha = false;
            }
            if(checkBox1.Checked==false) {
                estadofecha = true;
            }
            
        }
    }
}
