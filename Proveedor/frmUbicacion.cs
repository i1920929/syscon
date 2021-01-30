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
    public partial class frmUbicacion : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarUbicacion", SYSCON.cadconex); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dbgUbicacion.DataSource = dt; 
            da.Dispose();
        }
        public frmUbicacion()
        {
            InitializeComponent();
        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dbgUbicacion.Enabled = true;
            if (txtdescripcion.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtdescripcion.Focus();
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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsertarUbicacion '" + txtdescripcion.Text.ToUpper() + "'", SYSCON.cadconex);
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text == "")
            {
                SYSCON.MensajeValidacion(this.groupBox2);
                txtdescripcion.Focus();
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
                        SqlDataAdapter da = new SqlDataAdapter("Sp_ActualizarUbicacion '" + txtdescripcion.Text.ToUpper() + "','" + txtcodigo.Text + "'", SYSCON.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cargartabla();
                        da.Dispose();
                      
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se actualizó registro");
                    }
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            SYSCON.limpiar(this.groupBox2);
            txtdescripcion.Select();
            dbgUbicacion.Enabled = false;
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            SYSCON.Salir(this);
        }

        private void dbgUbicacion_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            txtdescripcion.Text=Convert.ToString(dbgUbicacion.CurrentRow.Cells[1].Value);
            txtcodigo.Text = Convert.ToString(dbgUbicacion.CurrentRow.Cells[0].Value);
            }

            catch
            {
            }

        }
    }
}
