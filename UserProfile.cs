//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newSite11_3
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public UserProfile()
        {
            this.UserPhotos = new HashSet<UserPhoto>();
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string gender { get; set; }
        public string FBName { get; set; }
        public string FBID { get; set; }
        public string birthday { get; set; }
        public string location { get; set; }
        public string hometown { get; set; }
    
        public virtual ICollection<UserPhoto> UserPhotos { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
