using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTest1.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        public ActionResult Index(string artist, int page = 1, int totalcount = 0, bool counted = false)
        {

            int next = page + 1;
            int prev = page - 1;
            int firstelem = (page - 1) * 7;
            var dataContext = new SysClassesDataContext();

            if (!counted)
            {
                totalcount = dataContext.Photos.ToList().Count();

                counted = true;
            }


            if ((firstelem + 7) < totalcount)
            {
                ViewBag.NextPage = "/search/index?page=" + next.ToString() + "&totalcount=" + totalcount.ToString() + "&counted=" + counted.ToString();
            }
            else
            {
                ViewBag.NextPage = "";
            }

            if ((firstelem + 1) > 1)
            {
                ViewBag.PrevPage = "/search/index?page=" + prev.ToString() + "&totalcount=" + totalcount.ToString() + "&counted=" + counted.ToString();
            }
            else
            {
                ViewBag.PrevPage = "";
            }



            int not_displayed = totalcount - ((page - 1) * 7);

            if (not_displayed > 7)
            {
                    var Photos = from m in dataContext.Photos where m.Album.Artist.name==artist select m;
                    Photos = Photos.Skip((page - 1) * 7).Take(7);
                    ViewBag.start = firstelem + 1;
                    ViewBag.end = firstelem + 7;
                    return View(Photos.ToList());
            }
            else
            {
                var Photos = from m in dataContext.Photos where m.Album.Artist.name==artist select m;
                Photos = Photos.Skip((page - 1) * 7).Take(not_displayed);         
                ViewBag.start = firstelem + 1;
                ViewBag.end = firstelem + not_displayed;
                return View(Photos.ToList());
            }

        }
        

    }
}
