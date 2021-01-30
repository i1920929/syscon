using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proveedor
{
    class SYSCON
    {
        //public static SqlConnection cadconex = new SqlConnection("Server=DESKTOP-GOI6NDS;Database=BDSYSCON;Trusted_Connection=True;");
        public static SqlConnection cadconex = new SqlConnection("Server=tcp:serversyscon.database.windows.net,1433;Initial Catalog=BDSYSCON;Persist Security Info=False;User ID=syscon;Password=@dminic12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //public static SqlConnection cadconex = new SqlConnection("Server=IHR80PBC111\\MSSQLSERVERIC;Database=DBSYSCON;User Id = sa;Password =continental");
        public static string nivelseg, iduser, nombreuser;
      
        

        public static void limpiar(GroupBox frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    cmb.SelectedIndex = -1;
                }
                if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox mst = ctrl as MaskedTextBox;
                    mst.Clear();
                }
                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = ctrl as NumericUpDown;
                    nud.Value = 0;
                }
            }

        }


        public static void MensajeValidacion(GroupBox frm)
        {
                MessageBox.Show("No puede dejar campos sin información",
                "Error...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void MensajePreguntaIn(GroupBox frm)
        {
            byte x;
            x = Convert.ToByte(MessageBox.Show("¿Está seguro de insertar?",
                "Advertencia...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1));
        }

        public static void MensajePreguntaAc(GroupBox frm)
        {
            byte x;
            x = Convert.ToByte(MessageBox.Show("¿Está seguro de actualizar?",
                "Advertencia...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question));
        }
        public static void cargarbusqueda()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarBusqueda", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);

            da.Dispose();

        }
        public static void Salir(Form frm)
        {
            
            if (MessageBox.Show("¿Estas seguro de salir de esta pestaña?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                frm.Close();
               
                
                
            }
            else { }
        }
    }
}