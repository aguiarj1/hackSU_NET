using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackSU.Models
{
    public class GuestResponsecs
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your degree")]
        public string degree { get; set; }
        [Required(ErrorMessage = "Please enter your route")]
        public string route { get; set; }
    }
}
