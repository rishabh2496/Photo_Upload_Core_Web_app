using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Photo_Upload_Core_Web_app.BusinessLayer;
using Photo_Upload_Core_Web_app.Models;

namespace Photo_Upload_Core_Web_app.Pages.Comments
{
    //Gets all comments using a lamda 
    public class IndexModel : PageModel
    {
        private readonly Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext _context;

        public IndexModel(Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.Comment
                .Include(c => c.Photo)
                .Include(c => c.Viewer).ToListAsync();
        }
    }
}
