using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newSite11_3.Models
{
    public class PhotoKeywords
    {
        public int Id { get; set; }
        public int photo_photoID { get; set; }
        public int keyword_keywordID { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}