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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Proveedor
{
    public partial class frmPersonal : Form
    {

        public string DesEncriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarPersonal", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }

        public frmPersonal()
        {
            InitializeComponent();
        }
        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            cargartabla();
            txtNom.Select();
            dataGridView1.Columns[5].Visible = false;
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtCod.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtApePat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtApeMat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtDirec.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                txtCel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                cmbCargo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                //txtContra.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                dtpFechaNac.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
                cmbTipoDoc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                txtNumDoc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                txtemail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            }
            catch
            {
            }
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            bool estado = true;

            if (txtNom.Text == "" || txtApeMat.Text == "" || txtCel.Text == "" || txtContra.Text == "" || txtNumDoc.Text == "" || cmbCargo.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else if (txtNom.Text == "" || txtApeMat.Text == "" || txtCel.Text == "" || txtContra.Text == "" || txtNumDoc.TextLength < 8 || cmbCargo.Text == "")
            {

                txtNumDoc.Select();
                MessageBox.Show("El DNI  debe tener como minimo 8 digitos");

            }
            else if (txtCel.TextLength < 9)
            {
                MessageBox.Show("El número deben ser 9 digitos");
                txtCel.Select();

            }
            else if (txtNom.TextLength < 3 || txtApePat.TextLength < 3 || txtApeMat.TextLength < 3)
            {
                MessageBox.Show("El ingreso minimo Nombres y Apellidos es de 3 digitos ");
                txtNom.Select();

            }

            else if (txtContra.TextLength < 7)
            {
                MessageBox.Show("La contraseña debe tener com minimo 7 digitos");
                txtContra.Select();

            }

            else if (ComprobarFormatoEmail(txtemail.Text) == false)
            {
                MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto", txtemail.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }


            else
            {
                if (MessageBox.Show("¿Estas seguro de agregar?", "Advertencia",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarPersonal '" + txtNom.Text.ToUpper() + "','" + txtApePat.Text.ToUpper() + "','" + txtApeMat.Text.ToUpper() + "','" + txtDirec.Text.ToUpper() + "','" + txtCel.Text.ToUpper() + "','" + cmbCargo.Text.ToUpper() + "','" + DesEncriptar(txtContra.Text) + "','" + dtpFechaNac.Value.ToString("MM/dd/yyyy") + "','" + cmbTipoDoc.Text.ToUpper() + "','" + txtNumDoc.Text.ToUpper() + "','" + estado + "','" + txtemail.Text + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cargartabla();
                        da.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se inserto registro");
                    }
                }
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            bool estado = true;

            if (txtNom.Text == "" || txtApeMat.Text == "" || txtCel.Text == "" || txtContra.Text == "" || txtNumDoc.Text == "" || cmbCargo.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
            }
            else if (txtNom.Text == "" || txtApeMat.Text == "" || txtCel.Text == "" || txtContra.Text == "" || txtNumDoc.TextLength < 8 || cmbCargo.Text == "")
            {

                txtNumDoc.Select();
                MessageBox.Show("El DNI  debe tener como minimo 8 digitos");

            }
            else if (txtCel.TextLength < 9)
            {
                MessageBox.Show("El número deben ser 9 digitos");
                txtCel.Select();

            }
            else if (txtNom.TextLength < 3 || txtApePat.TextLength < 3 || txtApeMat.TextLength < 3)
            {
                MessageBox.Show("El ingreso minimo Nombres y Apellidos es de 3 digitos ");
                txtNom.Select();

            }

            else if (txtContra.TextLength < 7)
            {
                MessageBox.Show("La contraseña debe tener com minimo 7 digitos");
                txtContra.Select();

            }
            else
            {
                dataGridView1.Enabled = true;
                if (MessageBox.Show("¿Estas seguro de actualizar?", "advertencia",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {


                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarPersonal '" + Convert.ToInt32(txtCod.Text) + "','" + txtNom.Text.ToUpper() + "','" + txtApePat.Text.ToUpper() + "','" + txtApeMat.Text.ToUpper() + "','" + txtDirec.Text.ToUpper() + "','" + txtCel.Text + "','" + cmbCargo.Text.ToUpper() + "','" + DesEncriptar(txtContra.Text) + "','" + dtpFechaNac.Value.ToString("MM/dd/yyyy") + "','" + cmbTipoDoc.Text.ToUpper() + "','" + txtNumDoc.Text + "','" + estado + "','" + txtemail.Text + "'", SYSCON.cadconex);
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

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = -1;
            SYSCON.limpiar(this.groupBox2);
            txtNom.Select();
            dataGridView1.Enabled = false;
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void txtTeleP_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTeleP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void txtTeleP_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTeleP_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbTipoDoc.SelectedIndex == 0)
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
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoDoc.SelectedIndex)
            {
                case 0:
                    txtNumDoc.MaxLength = 8;
                    txtNumDoc.Clear();
                    break;
                case 1:
                    txtNumDoc.MaxLength = 15;
                    txtNumDoc.Clear();
                    break;
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool estado = false;
            if (MessageBox.Show("¿Estas seguro de eliminar?", "advertencia",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {


                    SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarPersonal '" + Convert.ToInt32(txtCod.Text) + "','" + txtNom.Text.ToUpper() + "','" + txtApePat.Text.ToUpper() + "','" + txtApeMat.Text.ToUpper() + "','" + txtDirec.Text.ToUpper() + "','" + txtCel.Text + "','" + cmbCargo.Text.ToUpper() + "','" + DesEncriptar(txtContra.Text) + "','" + dtpFechaNac.Value.ToString("MM/dd/yyyy") + "','" + cmbTipoDoc.Text.ToUpper() + "','" + txtNumDoc.Text + "','" + estado + "'", SYSCON.cadconex);
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
}

