using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Photo_Upload_Core_Web_app.BusinessLayer;
using Photo_Upload_Core_Web_app.Models;

namespace Photo_Upload_Core_Web_app.Pages.Uploaders
{
    //Gets the uploader using a linq query.
    public class IndexModel : PageModel
    {
        private readonly Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext _context;

        public IndexModel(Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext context)
        {
            _context = context;
        }

        public IList<Uploader> Uploader { get;set; }

        public async Task OnGetAsync()
        {
            Uploader = await (from uploader in _context.Uploader select uploader).ToListAsync();
        }
    }
}
