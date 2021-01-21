using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Status
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int st_Id { get; set; }

        [Display(Name = "Status"), Required(ErrorMessage = "Enter Status")]
        public string st_Name { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public string st_Datetime { get; set; }
    }
}