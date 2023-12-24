using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public abstract class Data
    {
        protected readonly string from;
        protected string to;
        protected string subject;
        protected readonly string smtp;
        protected readonly string pass;
        protected readonly int port;

        public Data()
        {
            from = "";
            to = "";
            subject = "Alerta de seguridad";
            smtp = "";
            pass = "";
            port = 587;
        }

        protected Data(string to, string subject)
        {
            this.to = to;
            this.subject = subject;
            from = "";
            smtp = "";
            pass = "";
            port = 587;
        }

        public virtual string SendEmail(string txt)
        {
            string ok = "";
            MailMessage mail = new MailMessage();
            try
            {
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(to));
                mail.Subject = subject;
                mail.Body = txt;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient(smtp);
                client.Port = port;
                client.Credentials = new NetworkCredential(from, pass);
                client.EnableSsl = true;
                client.Send(mail);
                ok = "";
            }
            catch (Exception e)
            {
                ok = "Error!: " + e.StackTrace;
            }
            return ok;
        }

        public virtual string SendFiles(string txt, List<string> paths)
        {
            string ok = "";
            MailMessage mail = new MailMessage();
            try
            {
                if (paths.Count > 0)
                {
                    foreach (string p in paths)
                        mail.Attachments.Add(new Attachment(p));
                }
            }
            catch (Exception e)
            {
                ok = "Error!: " + e.StackTrace;
            }


            try
            {
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(to));
                mail.Subject = subject;
                mail.Body = txt;
                mail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient(smtp);
                client.Port = port;
                client.Credentials = new NetworkCredential(from, pass);
                client.EnableSsl = true;
                client.Send(mail);
                ok = "";
            }
            catch (Exception e)
            {
                ok = "Error!: " + e.StackTrace;
            }

            return ok;
        }
    }
}
