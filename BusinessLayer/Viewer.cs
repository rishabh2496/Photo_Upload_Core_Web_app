using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo_Upload_Core_Web_app.BusinessLayer
{
    //The viewer of the photo who put commnets
    public class Viewer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

    }
}
