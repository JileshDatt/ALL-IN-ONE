using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Candidate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ca_Id { get; set; }

        [Display(Name = "First Name"), Required(ErrorMessage = "Enter First Name")]
        public string ca_Fname { get; set; }

        [Display(Name = "Last Name"), Required(ErrorMessage = "Enter Last Name")]
        public string ca_Lname { get; set; }

        [Display(Name = "Address"), Required(ErrorMessage = "Enter Your Address")]
        public string ca_Address { get; set; }

        [Display(Name = "City"), Required(ErrorMessage = "Enter City")]
        public string ca_City { get; set; }

        [Display(Name = "State"), Required(ErrorMessage = "Enter State")]
        public string ca_State { get; set; }

        [Display(Name = "Pincode"), Required(ErrorMessage = "Enter Pincode")]
        public int ca_Pin { get; set; }

        [Display(Name = "Contact Number"), Required(ErrorMessage = "Enter Your Contact Number")]
        public string ca_Contact_Number { get; set; }

        [Display(Name = "Email"), EmailAddress(ErrorMessage = "Please Enter Valid EmailId"), Required(ErrorMessage = "Enter Email")]
        public string ca_Email { get; set; }

        [Display(Name = "Education"), Required(ErrorMessage = "Enter Your Education")]
        public string ca_Education { get; set; }

        [Required(ErrorMessage = "Upload your Resume")]
        public string ca_Resume { get; set; }

        [Display(Name = "Experience"), Required(ErrorMessage = "Enter Your Experience")]
        public int ca_Experience { get; set; }

        [Display(Name = "Company")]
        public string ca_Company { get; set; }

        [Display(Name = "Password"), Required(ErrorMessage = "Enter Password")]
        public string ca_Password { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime ca_Datetime { get; set; }
    }
}