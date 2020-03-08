using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Photo_Upload_Core_Web_app.BusinessLayer;
using Photo_Upload_Core_Web_app.Models;

namespace Photo_Upload_Core_Web_app.Pages.Viewers
{
    //Updates the details of the viewer
    public class EditModel : PageModel
    {
        private readonly Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext _context;

        public EditModel(Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Viewer Viewer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Viewer = await _context.Viewer.FirstOrDefaultAsync(m => m.Id == id);

            if (Viewer == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Viewer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViewerExists(Viewer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ViewerExists(int id)
        {
            return _context.Viewer.Any(e => e.Id == id);
        }
    }
}
