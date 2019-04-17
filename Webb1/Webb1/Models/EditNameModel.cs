using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Webb1.Models;

namespace Webb1.Models
{
    public partial class EditNameModel
    {
        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "CUsername")]
        [Required]
        public string CUsername { get; set; }
    }
}