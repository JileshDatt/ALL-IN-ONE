using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int a_Id { get; set; }
       
        [Display(Name = "Name"), Required(ErrorMessage = "Enter Name")]
        public string a_Name { get; set; }

        [Display(Name = "Email"), EmailAddress(ErrorMessage = "Please Enter Valid EmailId"), Required(ErrorMessage = "Enter Email")]
        public string a_Email { get; set; }
        
        [Display(Name = "Password"), Required(ErrorMessage = "Enter Password")]
        public string a_Password { get; set; }
        
        [Required(ErrorMessage ="Upload Your Photo")]
        public string a_Photo { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime a_Datetime { get; set; }

    }
}