using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinalTest1.Controllers
{
    public class DownloadDataController : Controller
    {
        //
        // GET: /DownloadData/

        public ActionResult Index(string result = "")
        {
            ViewBag.result = result;
            return View();
        }
        public ActionResult DownloadUserInfo()
        {
            SysClassesDataContext db = new SysClassesDataContext();
            StreamWriter UserWriter = new StreamWriter("C:/Users.txt");
            var result = from m in db.UserProfiles select m;
            List<UserProfile> users = result.ToList();
            UserWriter.WriteLine("username\tbirthday\tname\tlocation\tuserID");
            foreach (UserProfile user in users)
            {
                UserWriter.WriteLine(user.UserName+"\t"+user.birthday+"\t"+user.name+"\t"+user.location+"\t"+user.UserId);
            }
            UserWriter.Close();
            return RedirectToAction("Index", "DownloadData", new { result = "Successfully downloaded users info" });
        }
        
    }
}
