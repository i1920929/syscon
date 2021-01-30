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
    public partial class frmDevolucion : Form
    {
        Int32 nvIdEntrada;
        Int32 nvIdSalida;
        int controlar = 0;
        int opc2;

        void ListarNroDoc()
        {

            SqlDataAdapter da = new SqlDataAdapter("ListarNroDocSalida'" + opc2 + "'", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtNumeroDoc.DataSource = dt;
            txtNumeroDoc.DisplayMember = "NroDoc";
            //cmbComprobante.ValueMember = "IdSubCategoria";
            da.Dispose();

        }
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
        void buscar()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Sp_BuscarNroDoc'" + txtNumeroDoc.Text + "','" + cmbtipodoc.Text + "'", SYSCON.cadconex);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvEProducto.DataSource = dt3;
            da3.Dispose();
        }
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            txtpersonal.Text = SYSCON.iduser;
            rellenacomboProveedor();
            
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].HeaderText = "IdProducto";
            dataGridView1.Columns[1].HeaderText = "Producto";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
            dataGridView1.Columns[3].HeaderText = "PrecioCosto";
            dataGridView1.Columns[4].HeaderText = "PrecioVenta";
            dataGridView1.Columns[5].HeaderText = "FechaVenc";
            dataGridView1.Columns[6].HeaderText = "FechaVencActivo";
            dataGridView1.Columns[6].Visible = false;

        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgvEProducto_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtproducto.Text = Convert.ToString(dgvEProducto.CurrentRow.Cells[3].Value);
                nudprecioc.Text = Convert.ToString(dgvEProducto.CurrentRow.Cells[5].Value);
                nudpreciov.Text = Convert.ToString(dgvEProducto.CurrentRow.Cells[6].Value);
               // dtpFechaVenc.Value = Convert.ToDateTime(dgvEProducto.CurrentRow.Cells[7].Value);

                nudCantidad.Maximum = Convert.ToInt32(dgvEProducto.CurrentRow.Cells[4].Value);
            }
            catch { }
        }



        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdProducto from Producto where Nombre='" + txtproducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtcproducto.Text = Convert.ToString(dt.Rows[0]["IdProducto"]);
                da.Dispose();

                SqlDataAdapter da2 = new SqlDataAdapter("select * from ProductoEntrada where IdProducto = '" + txtcproducto.Text + "' order by IdProductoEntrada DESC", SYSCON.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dtpFechaVenc.Value = Convert.ToDateTime(dt2.Rows[0]["FechaVenc"]);
                checkBox1.Checked =Convert.ToBoolean(dt2.Rows[0]["FechaVencActivo"]);
                da2.Dispose();

            }
            catch
            {
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtmotivo.Text == "" || cmbtipodoc.Text == "" || txtNumeroDoc.Text == "" || txtpersonal.Text == "" || nudpreciov.Text == "" || nudprecioc.Text == "" || txtproducto.Text == "" || nudCantidad.Value == 0)
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else
            {
                if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    controlar = 0;
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        int idpro;
                        idpro = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                        if (Convert.ToInt32(txtcproducto.Text) == idpro)
                        {
                            dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(nudCantidad.Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                            SYSCON.limpiar(this.groupBox5);
                            controlar++;

                        }
                    }


                    if (controlar == 0)
                    {
                        dataGridView1.Rows.Add(txtcproducto.Text, txtproducto.Text, nudCantidad.Value, nudprecioc.Text, nudpreciov.Text, dtpFechaVenc.Value.ToString("MM-dd-yyyy"));

                        SYSCON.limpiar(this.groupBox5);
                    }

                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dgvEProducto.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Aviso", MessageBoxButtons.YesNo);
                }
            }
        }

        private void btnREntradaP_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("¿Estas seguro de registrar la entrada de productos?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {



                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarEntrada '" + "ENTRADA INTERNA" + "','" + dtpEntrada.Value.ToString("MM-dd-yyyy") + "','" + txtpersonal.Text + "','" + "2" + "','" + txtNumeroDoc.Text + "','" + txtmotivo.Text + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();

                        //Se busca cabecera emitida en tabla docentrada 
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Entrada order by IdEntrada desc", SYSCON.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        nvIdEntrada = Convert.ToInt32(dt2.Rows[0]["IdEntrada"]);
                        da2.Dispose();

                        //Se busca cabecera emitida en tabla docentrada 
                        SqlDataAdapter da5 = new SqlDataAdapter("select top 1 * from Salida sa inner join Producto_Salida prosa on sa.IdSalida=prosa.IdSalida where  NroDoc='" + txtNumeroDoc.Text + "'", SYSCON.cadconex);
                        DataTable dt5 = new DataTable();
                        da5.Fill(dt5);
                        nvIdSalida = Convert.ToInt32(dt5.Rows[0]["IdProductoSalida"]);
                        da5.Dispose();


                        //Insertando Detalle de DocEntrada en la BD
                        int c;
                        for (c = 0; c <= dataGridView1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsertarProductoEntrada '" + nvIdEntrada + "','" + dataGridView1.Rows[c].Cells[0].Value + "','" + dataGridView1.Rows[c].Cells[2].Value + "','" + dataGridView1.Rows[c].Cells[3].Value + "','" + "" + "','" + dataGridView1.Rows[c].Cells[5].Value + "','" + dataGridView1.Rows[c].Cells[4].Value +"','"+ dataGridView1.Rows[c].Cells[6].Value + "'", SYSCON.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();

                            SqlDataAdapter da4 = new SqlDataAdapter("Sp_ActualizarCantSalida '" + nvIdSalida + "','" + dataGridView1.Rows[c].Cells[2].Value + "'", SYSCON.cadconex);
                            DataTable dt4 = new DataTable();
                            da4.Fill(dt4);
                            da4.Dispose();
                        }


                        MessageBox.Show("Ingreso procesado", "Aviso");
                        txtNumeroDoc.Text = "";
                        buscar();


                        txtpersonal.Text = "1";
                        dataGridView1.Rows.Clear();
                        txtCEntrada.Clear();
                        txtcproducto.Clear();
                        txtmotivo.Clear();
                        nudCantidad.Value = 0;
                        cmbtipodoc.Focus();
                        txtNumeroDoc.Text = "";
                        cmbtipodoc.SelectedIndex = -1;
                        cmbProveedor.SelectedIndex = -1;
                        txtmotivo.Clear();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbtipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipodoc.SelectedIndex == 0)
            {
                opc2 = 1;
                ListarNroDoc();
            }
            else if (cmbtipodoc.SelectedIndex == 1)
            {
                opc2 = 2;
                ListarNroDoc();
            }
            else if (cmbtipodoc.SelectedIndex == 2)
            {
                opc2 = 3;
                ListarNroDoc();
            }
            else if (cmbtipodoc.SelectedIndex == 3)
            {
                opc2 = 4;
                ListarNroDoc();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
