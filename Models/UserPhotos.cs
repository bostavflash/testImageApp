using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newSite11_3.Models
{
    public class UserPhotos
    {
        public int Id { get; set; }
        public int user_userID { get; set; }
        public int photo_photoID { get; set; }

        public virtual ICollection<UserProfile> Users { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}