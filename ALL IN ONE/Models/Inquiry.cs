using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Inquiry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int e_Id { get; set; }

        [Display(Name = "Name"), Required(ErrorMessage = "Enter Name")]
        public string e_Name { get; set; }

        [Display(Name = "Email"), EmailAddress(ErrorMessage = "Please Enter Valid EmailId"), Required(ErrorMessage = "Enter Email")]
        public string e_Email { get; set; }

        [Display(Name = "Inquiry"), Required(ErrorMessage = "Enter Inquiry")]
        public string e_Inquiry { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime e_Datetime { get; set; }
    }
}