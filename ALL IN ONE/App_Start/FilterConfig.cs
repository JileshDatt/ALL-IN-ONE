﻿using System.Web;
using System.Web.Mvc;

namespace ALL_IN_ONE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
