using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }

    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("tanviupadhyay68@gmail.com");
                mail.To.Add(toAddress);
                mail.Subject = "Test Mail";
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("tanviupadhyay68@gmail.com", "#03Upadhyay");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
