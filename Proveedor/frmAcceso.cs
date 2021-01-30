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
namespace Proveedor
{
    public partial class frmAcceso : Form
    {
        public static string password;
        public string DesEncriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public frmAcceso()
        {
            InitializeComponent();
        }
        
        private void frmAcceso_Load(object sender, EventArgs e)
        {
            txtusername.MaxLength = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apepat, apemat, username, userfullname;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_Acceso '" + txtusername.Text + "'", SYSCON.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SYSCON.nivelseg = dt.Rows[0][6].ToString();
                SYSCON.iduser = dt.Rows[0][0].ToString();
                password = (dt.Rows[0][7]).ToString();
                username = dt.Rows[0][1].ToString();
                apepat = dt.Rows[0][2].ToString();
                apemat = dt.Rows[0][3].ToString();
                userfullname = username + " " + apepat + " " + apemat;
                SYSCON.nombreuser = userfullname;

                if (txtPasswordE.Text == password)
                {
                    this.Hide();
                    frmBienvenida welcome = new frmBienvenida();
                    welcome.ShowDialog();
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    Visible = false;
                }
                else
                {
                    if (MessageBox.Show("La contraseña ingresada es incorrecta", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        txtcontra.Focus();
                    }
                }
            }
            catch
            {
                if (MessageBox.Show("El usuario ingresado no existe", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtusername.Focus();
                }
            }


        }

        private void frmAcceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            txtPasswordE.Text = DesEncriptar(txtcontra.Text);
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                button1_Click(txtcontra, e);
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Separator))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 500; 

            ToolTip tt = new ToolTip();
            tt.Show("Ingresar DNI", TB, 0, 0, VisibleTime);
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 500; 

            ToolTip tt = new ToolTip();
            tt.Show("Ingresar Contraseña", TB, 0, 0, VisibleTime);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frc = new RecuperarCuenta();
            frc.ShowDialog();
        }
    }
}

