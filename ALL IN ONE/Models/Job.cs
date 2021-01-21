using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Job
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int j_Id { get; set; }

        [ForeignKey("Recruiter"), Required(ErrorMessage = "Enter Recruiter Id")]
        public int r_Id { get; set; }

        [ForeignKey("Sub_category"), Required(ErrorMessage = "Enter Sub-Category Id")]
        public int sc_Id { get; set; }

        [Display(Name = "Job Title"), Required(ErrorMessage = "Enter Job Title")]
        public string j_Title { get; set; }

        [Display(Name = "Job Designation"), Required(ErrorMessage = "Enter Job Designation")]
        public string j_Designation { get; set; }

        [Display(Name = "Job Vacancy"), Required(ErrorMessage = "Enter Job Vacancy")]
        public string j_Vacancy { get; set; }

        [Display(Name = "Job Salary"), Required(ErrorMessage = "Enter Job Salary")]
        public string j_Salary { get; set; }

        [Display(Name = "Job Experience"), Required(ErrorMessage = "Enter Job Experience")]
        public string j_Experience { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime j_Datetime { get; set; }

        public Recruiter Recruiter { get; set; }

        public Sub_category sub_Category { get; set; }
    }
}