using System;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace DeMan
{
    class CHomeController
    {
        public IActionResult Index()
        {
           // return 0;//View();
        }
        public static string GetCulture(string code = "")
        {
            if (!String.IsNullOrEmpty(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }
    }
}
