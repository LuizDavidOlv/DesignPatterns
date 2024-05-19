using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1.Solid.Single_Resposability
{
    public class User
    {
        public int ClienteId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }


}
