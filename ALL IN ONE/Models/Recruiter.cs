using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Recruiter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int r_Id { get; set; }

        [Required(ErrorMessage = "Enter Registration Package Id")]
        public int rg_Id { get; set; }

        [Display(Name = "First Name"), Required(ErrorMessage = "Enter First Name")]
        public string r_Fname { get; set; }

        [Display(Name = "Last Name"), Required(ErrorMessage = "Enter Last Name")]
        public string r_Lname { get; set; }

        [Display(Name = "Contact Number"), Required(ErrorMessage = "Enter Your Contact Number")]
        public int r_Contact_Number { get; set; }

        [Display(Name = "Bussiness Name"), Required(ErrorMessage = "Enter Bussiness Name")]
        public string r_Bussiness_Name { get; set; }

        [Required(ErrorMessage = "Upload Logo")]
        public string r_Logo { get; set; }

        [Display(Name = "Email"), EmailAddress(ErrorMessage = "Please Enter Valid EmailId"), Required(ErrorMessage = "Enter Email")]
        public string r_Email { get; set; }

        [Display(Name = "Address"), Required(ErrorMessage = "Enter Your Address")]
        public string r_Address { get; set; }

        [Display(Name = "City"), Required(ErrorMessage = "Enter City")]
        public string r_City { get; set; }

        [Display(Name = "State"), Required(ErrorMessage = "Enter State")]
        public string r_State { get; set; }

        [Display(Name = "Pincode"), Required(ErrorMessage = "Enter Pincode")]
        public int r_Pin { get; set; }

        [Display(Name = "Password"), Required(ErrorMessage = "Enter Password")]
        public string r_Password { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime r_Datetime { get; set; }
    }
}