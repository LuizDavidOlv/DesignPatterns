using _1._1.Solid.Single_Resposability;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace src.SOLID._1_SingleResposability.EmailExample.SrpCompliant
{
    public class UserService
    {
        EmailService _emailService;
        public UserService(EmailService aEmailService)
        {
            _emailService = aEmailService;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            Console.WriteLine($"User {user.Email} registered.");

            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        }
    }

}
}
