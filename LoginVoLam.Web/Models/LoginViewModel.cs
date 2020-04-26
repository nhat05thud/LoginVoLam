using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginVoLam.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Nhập UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Nhập Password")]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}