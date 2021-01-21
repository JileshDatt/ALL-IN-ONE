using ALL_IN_ONE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ALL_IN_ONE.Controllers
{
    public class AccountController : Controller
    {
        public string SignIn(Models.Login login)
        {
            string txnId = DateTime.Now.ToString("yyMMdd") + new Random().Next().ToString().Remove(4);
            return txnId;
        }

    }
}