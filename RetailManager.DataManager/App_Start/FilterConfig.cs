﻿using System.Web;
using System.Web.Mvc;

namespace RetailManager.DataManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
