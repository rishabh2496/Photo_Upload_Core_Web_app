using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Photo_Upload_Core_Web_app.BusinessLayer
{
    //Photo details and upload data 
    public class Photo
    {
        public int Id {get; set;}

        public string Caption { get; set; }


        public string ImageURL { get; set; }


        [NotMapped]
        public IFormFile ImageData { get; set; }


        public int UploaderId { get; set; }


        public Uploader Uploader { get; set; }



    }
}
