using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Feedback
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int f_Id { get; set; }

        [ForeignKey("Recruiter"), Required(ErrorMessage ="Enter Recruiter Id")]
        public int r_Id { get; set; }

        [ForeignKey("Candidate"), Required(ErrorMessage = "Enter Candiadte Id")]
        public int ca_Id { get; set; }

        [Display(Name = "FeedBack"), Required(ErrorMessage = "Enter Feedback")]
        public string f_Feedback { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime f_Datetime { get; set; }
        public Recruiter Recruiter { get; set; }
        public Candidate Candidate { get; set; }
    }
}