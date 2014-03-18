using FinalTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class KeywordingController : Controller
    {
        //
        // GET: /Keywording/

        public ActionResult Index(int page = 1, string sortOrder = "likes")
        {

            int next = page + 1;
            int prev = page - 1;
            int firstelem = (page - 1);


            PassData Pass = new PassData();
            var dataContext = new SysClassesDataContext();
            int totalCount = dataContext.Photos.Count();
            ViewBag.totalCount = totalCount;
            ViewBag.CurrentPage = page;
            ViewBag.sortOrder = sortOrder;
            if ((firstelem + 1) <= totalCount)
            {
                ViewBag.NextPage = "/keywording/index?page=" + next.ToString()+"&sortOrder="+sortOrder;
            }
            else
            {

                ViewBag.NextPage = "";
            }

            if ((firstelem + 1) > 1)
            {
                ViewBag.PrevPage = "/keywording/index?page=" + prev.ToString()+"&sortOrder="+sortOrder;
            }
            else
            {
                ViewBag.PrevPage = "";
            }
            var temp = from m in dataContext.Photos.OrderByDescending(x => x.likesNO).Skip(page - 1).Take(1) select m;
            Pass.xPhoto = temp.ToList<Photo>()[0];
            var temp2 = from m2 in dataContext.Keywords
                        select m2;
            Pass.CurrentKeyword = temp2.ToList();
            UserPhoto up1 = new UserPhoto { photo_photoID = Pass.xPhoto.Id, user_userID = (from m in dataContext.UserProfiles where m.UserName.Equals(User.Identity.Name) select m).ToList()[0].UserId};
            dataContext.UserPhotos.InsertOnSubmit(up1);
            dataContext.SubmitChanges();
            return View(Pass);
        }

    }
}
