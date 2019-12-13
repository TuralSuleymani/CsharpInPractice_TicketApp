using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp_P113.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

      
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string ConfirmPassword { get; set; }
    }
}
