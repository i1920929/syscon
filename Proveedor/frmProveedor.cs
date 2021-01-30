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
    public partial class frmProveedor : Form
    {
        ApiRest.DBApi dBApi = new ApiRest.DBApi();
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarProveedor", SYSCON.cadconex);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            da.Dispose();
        }
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargartabla();
            SYSCON.limpiar(this.groupBox2);
            txtRUC.Focus();
        }

       
          
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            if (txtRsocial.Text == "" || txtRUC.Text == "" || txtTele.Text == "" || txtDirec.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else if (txtRsocial.TextLength < 3)
            {
                MessageBox.Show("La razón social tiene que tener como minimo 3 digitos");
                txtRUC.Select();

            }
            else if (txtRUC.TextLength < 11 && txtTele.TextLength < 9)
            {
                MessageBox.Show("Corregir RUC y celular");
                txtRUC.Select();
            }
            else if (txtRUC.TextLength < 11)
            {
                MessageBox.Show("El RUC debe tener 11 digitos");
                txtRUC.Select();

            }

            else if (txtTele.TextLength < 9)
            {
                MessageBox.Show("El celular debe tener 9 digitos");
                txtTele.Select();

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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarProveedor '" + txtRsocial.Text.ToUpper() + "','" + txtTele.Text.ToUpper() + "','" + txtDirec.Text.ToUpper() + "','" + txtRUC.Text.ToUpper() + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt); da.Dispose();
                        cargartabla();
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            if (txtRsocial.Text == "" || txtRUC.Text == "" || txtTele.Text == "" || txtDirec.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else if (txtRsocial.TextLength< 3)
            {
                MessageBox.Show("La razón social tiene que tener como minimo 3 digitos");
                txtRUC.Select();

            }
            else if (txtRUC.TextLength < 11)
            {
                MessageBox.Show("El RUC debe tener 11 digitos");
                txtRUC.Select();

            }

            else if (txtTele.TextLength < 9)
            {
                MessageBox.Show("El teléfono debe tener 9 digitos");
                txtTele.Select();

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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarProveedor '" + txtCod.Text.ToUpper() + "','" + txtRsocial.Text.ToUpper() + "','" + txtTele.Text.ToUpper() + "','" + txtDirec.Text.ToUpper() + "','" + txtRUC.Text.ToUpper() + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt); da.Dispose();
                        cargartabla();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se actualizó registro");
                    }
                }
            }
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            txtRsocial.Select();
            dataGridView1.Enabled = false;
        }

        private void dataGridView1_CurrentCellChanged_1(object sender, EventArgs e)
        {

            try
            {
                txtCod.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtRsocial.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtTele.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtDirec.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtRUC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }

            catch
            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTele_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRsocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic respuesta = dBApi.Get("https://api.sunat.cloud/ruc/" + txtRUC.Text);

                txtRsocial.Text = respuesta.razon_social.ToString();
                txtcondicion.Text = respuesta.contribuyente_condicion.ToString();
                txttipo.Text = respuesta.contribuyente_tipo.ToString();
                txtestado.Text= respuesta.contribuyente_estado.ToString();
                txtDirec.Text= respuesta.domicilio_fiscal.ToString();
            }
            catch {
                MessageBox.Show("Nro RUC no valido");
                SYSCON.limpiar(this.groupBox2);
                txtRUC.Focus();
            }
        }
    }
}
