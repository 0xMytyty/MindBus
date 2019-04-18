using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webb1.Models
{
    public partial class EditPassModel
    {
        [Display(Name = "Old Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "New Password")]
        [Required]
        [DataType(DataType.Password)]
        public string NPassword { get; set; }

        [Display(Name = "Confirm New Password")]
        [Required]
        [DataType(DataType.Password)]
        public string CNPassword { get; set; }
    }
}