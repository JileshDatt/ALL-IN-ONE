using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Registration_package
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int rg_Id { get; set; }

        [Display(Name = "Registation Package Name"), Required(ErrorMessage = "Enter Registation Package Name")]
        public string rg_Packagename { get; set; }

        [Display(Name = "Registation Duration"), Required(ErrorMessage = "Enter Registation Duration")]
        public string rg_Duration { get; set; }

        [Display(Name = "Registation Price"), Required(ErrorMessage = "Enter Registation Price")]
        public int rg_Price { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime rg_Datetime { get; set; }
    }
}