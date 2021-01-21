using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ALL_IN_ONE.Models
{
    public class DBWEBAPP  : DbContext
    {
        public DBWEBAPP()
        {
            
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Recruiter> Recruiters { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}