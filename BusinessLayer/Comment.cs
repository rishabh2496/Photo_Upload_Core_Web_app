using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo_Upload_Core_Web_app.BusinessLayer
{

    //A comment from a viewer about a photo
    public class Comment
    {
        public int Id { get; set; }


        public  string  Content { get; set; }

        public int PhotoId { get; set; }

        public int ViewerId { get; set; }

        public Viewer Viewer { get; set; }

        public Photo Photo { get; set; }




    }
}
