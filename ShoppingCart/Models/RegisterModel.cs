using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class RegisterModel
    {
        public string Username { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
