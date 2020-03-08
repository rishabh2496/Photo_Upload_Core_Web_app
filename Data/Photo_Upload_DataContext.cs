using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Photo_Upload_Core_Web_app.BusinessLayer;

namespace Photo_Upload_Core_Web_app.Models
{
    //The database connection  information
    public class Photo_Upload_DataContext : DbContext
    {
        public Photo_Upload_DataContext (DbContextOptions<Photo_Upload_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Photo_Upload_Core_Web_app.BusinessLayer.Comment> Comment { get; set; }

        public DbSet<Photo_Upload_Core_Web_app.BusinessLayer.Photo> Photo { get; set; }

        public DbSet<Photo_Upload_Core_Web_app.BusinessLayer.Uploader> Uploader { get; set; }

        public DbSet<Photo_Upload_Core_Web_app.BusinessLayer.Viewer> Viewer { get; set; }
    }
}
