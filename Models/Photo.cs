using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newSite11_3.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int likesNO { get; set; }
        public int commentsNO { get; set; }
        public int sharesNO { get; set; }
        public int albumID { get; set; }
        public string FBID { get; set; }

        public virtual Album Album { get; set; }
    }
}