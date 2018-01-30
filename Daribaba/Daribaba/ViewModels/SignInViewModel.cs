using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Daribaba.ViewModels
{
    public class SignInViewModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}