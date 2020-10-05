using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using backend.model;

namespace backend.Pages.workshop
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContetxt _db;

        public IndexModel(ApplicationDbContetxt db)
        {
            _db = db;
        }

        public IEnumerable<model.Workshop> Workshops { get; set; }

        public async Task OnGet()
        {
            Workshops = await _db.Workshop.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var workshop = await _db.Workshop.FindAsync(id);

            if (workshop == null)
            {
                return NotFound();
            }
            _db.Workshop.Remove(workshop);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
        
    }
}
