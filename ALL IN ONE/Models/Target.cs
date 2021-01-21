using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Target
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int t_Id { get; set; }

        [Display(Name = "Target Date"), Required(ErrorMessage = "Enter Target Date")]
        public DateTime t_Date { get; set; }

        [Display(Name = "Target"), Required(ErrorMessage = "Enter Target")]
        public int t_Target { get; set; }

        [Display(Name = "Accomplishment"), Required(ErrorMessage = "Enter Accomplishment")]
        public string t_Accomplishment { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime t_DateTime { get; set; }
    }
}