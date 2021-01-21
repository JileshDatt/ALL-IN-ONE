using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Login
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int l_Id { get; set; }

        [ForeignKey("Recruiter"), Required(ErrorMessage = "Enter Recruiter Id")]
        public int r_Id { get; set; }

        [ForeignKey("Status"), Required(ErrorMessage = "Enter Status Id")]
        public int st_Id { get; set; }

        [ForeignKey("Candidate"), Required(ErrorMessage = "Enter Candidate Id")]
        public int ca_Id { get; set; }
        public string texn_Id { get; set; }

        [Display(Name = "UserName"), Required(ErrorMessage = "Enter UserName")]
        public string l_Username { get; set; }

        [Display(Name = "Password"), Required(ErrorMessage = "Enter Password")]
        public string l_Password { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime l_Datetime { get; set; }

        public Recruiter Recruiter { get; set; }
        public Status Status { get; set; }
        public Candidate Candidate { get; set; }


    }
}