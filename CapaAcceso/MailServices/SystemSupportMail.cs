using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcceso.MailServices
{
    public class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail(){
            senderMail = "helpsyscon@gmail.com";
            password = "adminsyscon";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            IniciarSmtpClient();
        }
    }
}
