using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace _1._1.Solid.Single_Resposability.SrpWithCompliance
{
    public class UserServices
    {
        EmailServices _emailServices;
        public UserServices(EmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        public void Register(string email, string password)
        {
            if(!_emailServices.ValidateEmail(email))
                throw new ValidationException("Email is not an valid email");
            var user = new User(email, password);

            //Save on the db

            _emailServices.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hello foo" });
        }


    }
}
