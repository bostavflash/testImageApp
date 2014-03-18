using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class AddKeywordController : Controller
    {
        //
        // GET: /AddKeyword/

        public ActionResult Index(int page, string sortOrder, long photoID, int keywordID)
        {
            SysClassesDataContext db = new SysClassesDataContext();
            db.PhotoKeywords.InsertOnSubmit(new PhotoKeyword { keyword_keywordID = keywordID, photo_photoID = photoID });
            db.SubmitChanges();
            return RedirectToAction("Index", "Keywording", new { page = page+1, sortOrder = sortOrder });
        }

    }
}
