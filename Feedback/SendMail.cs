using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Feedback
{
    class SendMail
    {
        private string bodyMail;
        private string nameAuthor;
        private const string passMail = " ";
        private string subject = "";

        public SendMail(string bodyMail, string nameAuthor, string subject)
        {
            this.bodyMail = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
        }

        public void MySendMail()
        {
            var from = new MailAddress(" ", nameAuthor);
            var to = new MailAddress(" ", "Стас Кудрявцев");

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from.Address, passMail);
                smtp.EnableSsl= true;
                smtp.Timeout= 20000;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = bodyMail;

                smtp.Send(mail);

                MessageBox.Show("Сообщение доставлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
namespace System.Net
{

}
namespace System.Net.Mail
{

}