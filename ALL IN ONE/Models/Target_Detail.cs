using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Target_Detail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int td_Id { get; set; }

        [ForeignKey("Target"), Required(ErrorMessage = "Enter Target Id")]
        public int t_Id { get; set; }

        [ForeignKey("Interview"), Required(ErrorMessage = "Enter Interview Id")]
        public int i_Id { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime td_Datetime { get; set; }
        public Target Target { get; set; }
        public Interview Interview { get; set; }

    }
}