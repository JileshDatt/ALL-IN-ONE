using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALL_IN_ONE.Models;

namespace ALL_IN_ONE.Controllers
{
    [Authorize]
    public class CandidateController : Controller
    {
        // GET: Candidate
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken()]
        public ActionResult Create( Candidate candidate)
        {
            
                if (!ModelState.IsValid)
                {
                    return View(candidate);
                }

            var db = new DBWEBAPP();
            db.Candidates.Add(candidate);
            db.SaveChanges();
         
            return View();
        }
    }
}