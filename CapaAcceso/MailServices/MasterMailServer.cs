using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CapaAcceso.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void IniciarSmtpClient() {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void EnviarMail(string subject,string body,List<string> recipientMail) {
            var mensajeMail = new MailMessage();
            try
            {
                mensajeMail.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mensajeMail.To.Add(mail);
                }
                mensajeMail.Subject = subject;
                mensajeMail.Body = body;
                mensajeMail.Priority = MailPriority.Normal;
                smtpClient.Send(mensajeMail);
        
            }
            catch(Exception ex) {}
            finally {
                mensajeMail.Dispose();
                smtpClient.Dispose();
            }

        }
    }
}
