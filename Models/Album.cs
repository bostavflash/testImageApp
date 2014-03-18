using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newSite11_3.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string FBID { get; set; }
        public int artistID { get; set; }
        public string title { get; set; }

        virtual public Artist Artist { get; set; }
    }
}