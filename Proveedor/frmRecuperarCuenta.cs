using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAcceso;

namespace Proveedor
{
    public partial class RecuperarCuenta : Form
    {
        public RecuperarCuenta()
        {
            InitializeComponent();
        }

        public string DesEncriptar(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        void EnvioEmail() {

            


        }

        void RecuperaCuenta()
        {
        
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personal where NumDoc='" + txtusername.Text + "'", SYSCON.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            if (dt.Rows.Count > 0)
            {

                string username = Convert.ToString(dt.Rows[0]["Nombres"]);
                string userapepat = Convert.ToString(dt.Rows[0]["ApellidoPat"]);
                string userapemat= Convert.ToString(dt.Rows[0]["ApellidoMat"]);
                string userfullname = username+ " " + userapepat + " " + userapemat;
                string usermail = Convert.ToString(dt.Rows[0]["Email"]);
                string passwordencrip = Convert.ToString(dt.Rows[0]["Contra"]);
                string passworddesncrip = DesEncriptar(passwordencrip);
                var mailServices = new CapaAcceso.MailServices.SystemSupportMail();
                mailServices.EnviarMail(
                    subject: "SYSCON: Solicitud de Recuperación de Cuenta",
                    body: "Hola," + userfullname + "\nsolicitaste recuperar tu cuenta.\n" +
                    "Tu contraseña es la siguiente: " + passworddesncrip +
                    "\nTe sugerimos que cambies tu contraseña inmediatamente despues de ingresar al sistema.  ",
                    recipientMail: new List<string> { usermail }
                    );
                lblmensaje.Text = "Hola," + userfullname + "\nSolicitaste recuperar tu cuenta.\n" +
                    "Por favor revise su Email: " + usermail +
                    "\nTe sugerimos que cambies tu contraseña\ninmediatamente despues de \ningresar al sistema. ";
            }
            else {
               lblmensaje.Text = "El usuario ingresado no esta registrado en el sistema" ;
            }

        }

        private void RecuperarCuenta_Load(object sender, EventArgs e)
        {
            txtusername.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecuperaCuenta();

        }
    }
}
