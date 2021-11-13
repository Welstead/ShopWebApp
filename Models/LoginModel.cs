using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100, MinimumLength =2)]
        [EmailAddress] //checks for valid email address
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)] //masks entered characters with ***
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public string LoginInValid { get; set; }
    }
}
