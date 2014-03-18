using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //SysClassesDataContext sysContext = new SysClassesDataContext();
            //sysContext.Keywords.InsertOnSubmit(new Keyword { keywordText = "religious" });
            //sysContext.Keywords.InsertOnSubmit(new Keyword { keywordText = "radicalism" });
            //sysContext.Keywords.InsertOnSubmit(new Keyword { keywordText = "event" });
            //sysContext.Keywords.InsertOnSubmit(new Keyword { keywordText = "woman" });
            //sysContext.Keywords.InsertOnSubmit(new Keyword { keywordText = "baby" });
            //sysContext.SubmitChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
