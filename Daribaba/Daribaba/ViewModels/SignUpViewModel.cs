using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daribaba.ViewModels
{
    public class SignUpViewModel
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
    }
}