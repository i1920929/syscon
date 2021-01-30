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
    public partial class frmSalida : Form
    {

        int nvIdSalida;
        int controlar = 0;
        int controlars = 0;
        int cant;
        int opc;
       
        void rellenacategoria()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarCategoria", SYSCON.cadconex);              
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbcategoria.DataSource = dt;
            cmbcategoria.DisplayMember = "Nombre_Categoria";
            cmbcategoria.ValueMember = "IdCategoria";
            da.Dispose();
        }

        void actualnumdoc()
        {

            if (cmbtipodoc.Text == "BOLETA")
            {
                opc = 1;


            }
            if (cmbtipodoc.Text == "FACTURA")
            {
                opc = 2;

            }
            if (cmbtipodoc.Text == "GUIA DE REMISIÓN")
            {
                opc = 3;

            }
            if (cmbtipodoc.Text == "SALIDA INTERNA")
            {
                opc = 4;

            }
            SqlDataAdapter da = new SqlDataAdapter("Sp_Numerodocumento1 '" + opc + "'", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtdocumento.Text = "00" + Convert.ToString(dt.Rows[0]["NroDocActual"]);
            da.Dispose();

        }

        void actualstock()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Stock from Producto where IdProducto='" + txtIdProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtstock.Text = Convert.ToString(dt.Rows[0]["Stock"]);
                da.Dispose();
            }
            catch
            {
            }
            
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
        void cargaproducto()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from Producto where  IdSubCategoria='" + cmbsubcategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbproducto.DataSource = dt;
                cmbproducto.DisplayMember = "Nombre";
                cmbproducto.ValueMember = "IdProducto";
                da.Dispose();
            }
            catch{}
        }


        void cargarsaldida()
        {
            dgv1.ColumnCount = 6;
            dgv1.Columns[0].HeaderText = "IdProducto";
            dgv1.Columns[1].HeaderText = "Producto";
            dgv1.Columns[2].HeaderText = "Cantidad";
            dgv1.Columns[3].HeaderText = "PrecioCosto";
            dgv1.Columns[4].HeaderText = "PrecioVenta";
            dgv1.Columns[5].HeaderText = "Importe";
        }
        public frmSalida()
        {
            InitializeComponent();
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            txtpersonal.Text = SYSCON.iduser;
            cmbtipodoc.Focus();
            rellenacategoria();
            cargarsaldida();
            rellenasubcat();
            cargaproducto();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            cmbtipodoc.Select();
            txtpersonal.Text = SYSCON.iduser;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarSalida'" + txtCod.Text + "','" + cmbtipodoc.Text + "','" + txtdocumento.Text + "','" + dtmfechasalida.Value.ToString("MM/dd/yyyy") + "','" + txtpersonal.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                MessageBox.Show("Registro actualizado exitosamente");
            }
            catch
            {
                MessageBox.Show("Error, no se actualizó registro");
            }
        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdProducto from Producto where Nombre='" + cmbproducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                txtIdProducto.Text = Convert.ToString(dt.Rows[0]["IdProducto"]); 
                da.Dispose();
            }
            catch
            {
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PrecioVenta from Producto where IdProducto='" + txtIdProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtpreciov.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                da.Dispose();
            }
            catch
            {
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select PrecioCosto from Producto where IdProducto='" + txtIdProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtprecio.Text = Convert.ToString(dt.Rows[0]["PrecioCosto"]);
                da.Dispose();
            }
            catch
            {
            }

            actualstock();
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select UnidadMedida.Simbolo from Producto INNER JOIN UnidadMedida ON UnidadMedida.IdUnidadMedida=Producto.IdUnidadMedida where IdProducto='" + txtIdProducto.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtunidad.Text = Convert.ToString(dt.Rows[0]["Simbolo"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void cmdagrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtipodoc.Text == "" || txtdocumento.Text == "" || txtpersonal.Text == "" || txtpreciov.Text == "" || cmbcategoria.Text == "" || cmbsubcategoria.Text == "" || cmbproducto.Text == "" || nudcantidad.Value == 0)
                {
                    SYSCON.MensajeValidacion(this.groupBox2);
                }

                else
                {
                    if (Convert.ToInt32(txtstock.Text) > nudcantidad.Value)
                    {

                        if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {


                            //cant = Convert.ToInt32(nudcantidad.Value);
                            controlar = 0;
                            controlars = 0;
                            for (int i = 0; i <= dgv1.RowCount - 1; i++)
                            {
                                int idpro;
                                idpro = Convert.ToInt32(dgv1.Rows[i].Cells[0].Value);

                                if (Convert.ToInt32(txtIdProducto.Text) == idpro)
                                {
                                    cant = cant + Convert.ToInt32(nudcantidad.Value);
                                    if (cant < Convert.ToInt32(txtstock.Text))
                                    {
                                        dgv1.Rows[i].Cells[2].Value = Convert.ToInt32(nudcantidad.Value) + Convert.ToInt32(dgv1.Rows[i].Cells[2].Value);

                                        controlar++;
                                        controlars++;
                                        //MessageBox.Show("" + cant);
                                    }
                                    else
                                    {
                                        MessageBox.Show("SUPERA EL STOCK");
                                        controlars++;
                                        cant = Convert.ToInt32(dgv1.Rows[i].Cells[2].Value);

                                    }

                                }

                            }



                            if (Convert.ToInt32(txtstock.Text) > Convert.ToInt32(nudcantidad.Value) && controlar == 0 && controlars == 0)
                            {
                                cant = Convert.ToInt32(nudcantidad.Value);
                                dgv1.Rows.Add(txtIdProducto.Text, cmbproducto.Text, nudcantidad.Value, txtprecio.Text, txtpreciov.Text, Convert.ToDouble(nudcantidad.Value) * Convert.ToDouble(txtpreciov.Text));
                                nudcantidad.Value = 0;
                                SYSCON.limpiar(this.groupBox5);
                                SYSCON.limpiar(this.groupBox6);
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("La cantidad de productos supera el stock actual");
                    }

                }
            }
            catch
            { 
            }

        }


                
         
        


        private void button7_Click(object sender, EventArgs e)
        {
            if (dgv1.RowCount > 0) 
            { 
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                { 
                    dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                }
                
            }

            else
            {
                MessageBox.Show("No existen items para eliminar", "Aviso", MessageBoxButtons.OK);
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (dgv1.RowCount > 0)
            {
                if (MessageBox.Show("¿Estas seguro de registrar la salida de productos?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string numdoc;
                        numdoc = txtserie.Text +"-" + txtdocumento.Text;
                        //Se busca cabecera emitida en tabla docentrada 
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarSalida'" + cmbtipodoc.Text.ToUpper() + "','" + numdoc + "','" + dtmfechasalida.Value.ToString("MM-dd-yyyy") + "','" + txtpersonal.Text + "','" + txtdocumento.Text.ToString() + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        //Insertando Detalle de DocEntrada en la BD za
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Salida order by IdSalida desc", SYSCON.cadconex);
                        DataTable dt2 = new DataTable(); da2.Fill(dt2);
                        nvIdSalida = Convert.ToInt32(dt2.Rows[0]["IdSalida"]);
                        da2.Dispose();

                        int c;
                        for (c = 0; c <= dgv1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsertarProductoSalida '" + dgv1.Rows[c].Cells[0].Value + "','" + nvIdSalida + "','" + dgv1.Rows[c].Cells[2].Value + "','" + dgv1.Rows[c].Cells[3].Value + "','" + dgv1.Rows[c].Cells[4].Value + "'", SYSCON.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3); da3.Dispose();
                        }

                        MessageBox.Show("Salida procesada", "Aviso");
                        actualnumdoc();
                        SqlDataAdapter da4 = new SqlDataAdapter("Sp_ActualizarSalida'" + nvIdSalida + "','" + cmbtipodoc.Text.ToUpper() + "','" + dtmfechasalida.Value.ToString("MM-dd-yyyy") + "','" + txtpersonal.Text + "','" + txtdocumento.Text.ToString() + "'", SYSCON.cadconex);
                        DataTable dt4 = new DataTable();
                        da4.Fill(dt4);
                        da4.Dispose(); 
          
                        dgv1.Rows.Clear();
                        cmbtipodoc.Focus();
                        txtdocumento.Clear();
                        SYSCON.limpiar(this.groupBox5);
                        SYSCON.limpiar(this.groupBox6);

                        Form f1 = new frmImpresionSalida();

                        f1.Show();
                    }
                    catch
                    {
                    }
                }
                else { }

            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbpersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbsubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from Producto where  IdSubCategoria='" + cmbsubcategoria.SelectedValue + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbproducto.DataSource = dt;
                cmbproducto.DisplayMember = "Nombre" ;           
                cmbproducto.ValueMember = "IdProducto";
                da.Dispose();
            }

            catch { }
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

        private void dgv1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpreciov_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void cmbtipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualnumdoc();
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
