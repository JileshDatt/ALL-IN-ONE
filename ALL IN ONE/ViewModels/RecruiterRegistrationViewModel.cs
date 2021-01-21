using ALL_IN_ONE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.ViewModels
{
    public class RecruiterRegistrationViewModel
    {       
        public Recruiter Recruiter { get; set; }
        public Login Login { get; set; }
    }
}