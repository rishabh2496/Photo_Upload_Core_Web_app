using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Photo_Upload_Core_Web_app.BusinessLayer;
using Photo_Upload_Core_Web_app.Models;

namespace Photo_Upload_Core_Web_app.Pages.Photos
{
    public class CreateModel : PageModel
    {
        private readonly Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext _context;

        public CreateModel(Photo_Upload_Core_Web_app.Models.Photo_Upload_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UploaderId"] = new SelectList(_context.Set<Uploader>(), "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Photo Photo { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            PhotoUpload(Photo);
            _context.Photo.Add(Photo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        private void PhotoUpload(Photo photo)
        {

            if (photo.ImageData != null)
            {
                photo.ImageURL = photo.ImageData.FileName;

                var path = "./wwwroot/uploads/" + photo.ImageData.FileName;


                if (photo.ImageData.Length > 0)
                {
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        photo.ImageData.CopyTo(stream);
                    }
                }
            }


        }


    }
}
