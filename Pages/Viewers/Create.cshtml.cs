using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Photo_Upload_Core_Web_app.BusinessLayer;
using Photo_Upload_Core_Web_app.Models;

namespace Photo_Upload_Core_Web_app.Pages.Viewers
{
    //Creates the Viewer.
    public class CreateModel : PageModel
    {
        private readonly Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext _context;

        public CreateModel(Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Viewer Viewer { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Viewer.Add(Viewer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
