using System.Net.Mail;

namespace src.SOLID._1_SingleResposability.EmailExample.SrpCompliant
{
    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }
        public bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
            return true;
        }

    }
}
