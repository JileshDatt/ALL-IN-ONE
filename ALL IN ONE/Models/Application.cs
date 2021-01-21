using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Application
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ap_Id { get; set; }

        [ForeignKey("Job"), Required(ErrorMessage = "Select Job Id")]
        public int j_Id { get; set; }

        [ForeignKey("Candidate"), Required(ErrorMessage = "Select Candidate Id")]
        public int ca_Id { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime ap_Datetime { get; set; }

        public Job Job { get; set; }
        public Candidate Candidate { get; set; }
    }
}