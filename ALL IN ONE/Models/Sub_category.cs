using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Sub_category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sc_Id { get; set; }

        [ForeignKey("Category"), Required(ErrorMessage = "Enter Category Id")]
        public int c_Id { get; set; }

        [Display(Name = "Sub-Category Name"), Required(ErrorMessage = "Enter Sub-Category Name")]
        public string sc_Name { get; set; }

        [Display(Name = "Discription"), Required(ErrorMessage = "Enter Discription")]
        public string sc_Description { get; set; }

        [Required(ErrorMessage = "Upload Your Photo")]
        public string sc_Photo { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime sc_Datetime { get; set; }
        public Category Category { get; set; }
    }
}