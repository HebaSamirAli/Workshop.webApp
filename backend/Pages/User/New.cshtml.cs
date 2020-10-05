// model.user.new.C#....................................
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using backend.model;

namespace backend.Pages.User
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContetxt _db;

        public NewModel(ApplicationDbContetxt db)
        {
            _db = db;
        }

        [BindProperty]
        public model.User User { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.User.AddAsync(User);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
        public void OnGet()
        {
        }
    }
}
