using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class BrowsingOptionsController : Controller
    {
        //
        // GET: /BrowsingOptions/

        public ActionResult Index()
        {
            try
            {
                if (HttpContext.Session["accessToken"].Equals(""))
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            catch
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

    }
}
