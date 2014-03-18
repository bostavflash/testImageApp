using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class BrowseImagesController : Controller
    {
        //
        // GET: /BrowseImages/

        public ActionResult Index(int page = 1, string orderBy = "likes")
        {

            int next = page + 1;
            int prev = page - 1;
            int firstelem = (page - 1) * 7;
            var dataContext = new SysClassesDataContext();
            int totalCount = dataContext.Photos.Count();
            ViewBag.totalCount = totalCount;
            ViewBag.currPage = page;
            ViewBag.sortOrder = orderBy;
            int pagesNum = (int)Math.Ceiling(((double)totalCount) / 7);
            ViewBag.pagesNum = pagesNum;
            if ((firstelem + 7) < totalCount)
            {
                ViewBag.NextPage = "/browseimages/index?page=" + next.ToString() + "&orderBy=" + orderBy;
            }
            else
            {
                ViewBag.NextPage = "";
            }

            if ((firstelem + 1) > 1)
            {
                ViewBag.PrevPage = "/browseimages/index?page=" + prev.ToString() + "&orderBy=" + orderBy;
            }
            else
            {
                ViewBag.PrevPage = "";
            }



            int not_displayed = totalCount - ((page - 1) * 7);

            if (not_displayed > 7)
            {
                if (orderBy == "likes")
                {
                    var Photos = from m in dataContext.Photos.OrderByDescending(x => x.likesNO).Skip((page - 1) * 7).Take(7)
                                 select m;
                    ViewBag.start = firstelem + 1;
                    ViewBag.end = firstelem + 7;
                    return View(Photos.ToList());
                }
                else if (orderBy == "comments")
                {
                    var Photos = from m in dataContext.Photos.OrderByDescending(x => x.commentsNO).Skip((page - 1) * 7).Take(7)
                                 select m;
                    ViewBag.start = firstelem + 1;
                    ViewBag.end = firstelem + 7;
                    return View(Photos.ToList());
                }
                else if (orderBy == "artist")
                {
                    var Photos = from m in dataContext.Photos.OrderBy(x => x.Album.Artist).Skip((page - 1) * 7).Take(7)
                                 select m;
                    ViewBag.start = firstelem + 1;
                    ViewBag.end = firstelem + 7;
                    return View(Photos.ToList());
                }
                else
                {
                    var Photos = from m in dataContext.Photos.OrderByDescending(x => x.likesNO).Skip((page - 1) * 7).Take(7)
                                 select m;
                    ViewBag.start = firstelem + 1;
                    ViewBag.end = firstelem + 7;
                    return View(Photos.ToList());
                }
            }
            else
            {
                var Photos = from m in dataContext.Photos.OrderByDescending(x => x.likesNO).Skip((page - 1) * 7).Take(not_displayed)
                             select m;
                ViewBag.start = firstelem + 1;
                ViewBag.end = firstelem + not_displayed;
                return View(Photos.ToList());
            }

        }

    }
}
