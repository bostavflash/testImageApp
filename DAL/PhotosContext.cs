using newSite11_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace newSite11_3.DAL
{
    public class PhotosContext:DbContext
    {
        public PhotosContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoKeywords> PhotoKeywordsSet { get; set; }
        public DbSet<UserPhotos> UserPhotosSet { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}