﻿using System.Web;
using System.Web.Mvc;

namespace Assignment_Yurun_N01429970
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
