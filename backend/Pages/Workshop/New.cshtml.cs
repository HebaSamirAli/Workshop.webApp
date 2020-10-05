using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using backend.model;

namespace backend.Pages.Workshop
{
    public class NewModel : PageModel
    {
        public void OnGet()
        {
        }
        private readonly ApplicationDbContetxt _db;
        public NewModel(ApplicationDbContetxt db)
        {
            _db = db;
        }
        [BindProperty]
        public model.Workshop Workshop { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Workshop.AddAsync(Workshop);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
