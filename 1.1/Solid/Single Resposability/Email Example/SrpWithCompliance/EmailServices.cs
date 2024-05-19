using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace _1._1.Solid.Single_Resposability.SrpWithCompliance
{
    public class EmailServices
    {
        SmtpClient _smtpClient;
        public EmailServices(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
            return true;
        }

    }
}
