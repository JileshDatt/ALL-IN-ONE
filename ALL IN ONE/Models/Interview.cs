using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Interview
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int i_Id { get; set; }

        [ForeignKey("Application"), Required(ErrorMessage = "Enter Application Id")]
        public int ap_Id { get; set; }

        [ForeignKey("Status"), Required(ErrorMessage = "Enter Status Id")]
        public int st_Id { get; set; }

        [Required(ErrorMessage = "Enter Interview Date")]
        public DateTime i_Date { get; set; }

        [Display(Name = "Designation"), Required(ErrorMessage = "Enter Designation")]
        public string i_Designation { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime i_Datetime { get; set; }

        public Application Application { get; set; }
        public Status Status { get; set; }
    }
}