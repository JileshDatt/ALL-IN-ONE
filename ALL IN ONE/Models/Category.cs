using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int c_Id { get; set; }

        [Display(Name = "Category Name"), Required(ErrorMessage = "Enter Category Name")]
        public string c_Name { get; set; }

        [Display(Name = "Discription"), Required(ErrorMessage = "Enter Discription")]
        public string c_Discription { get; set; }

        [Required(ErrorMessage = "Upload Your Photo")]
        public string c_Photo { get; set; }

        [Required(ErrorMessage = "Update Datetime")]
        public DateTime c_Datetime { get; set; }
    }
}