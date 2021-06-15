using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestIdentity.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Pwd { get; set; }
        [Required]
        public string Pwd2 { get; set; }
    }
}
