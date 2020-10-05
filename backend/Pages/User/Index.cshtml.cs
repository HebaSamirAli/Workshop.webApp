// model.user.index.C#....................................

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using backend.model;
using Microsoft.EntityFrameworkCore;

namespace backend.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContetxt _db;

        public IndexModel(ApplicationDbContetxt db)
        {
            _db = db;
        }

        public IEnumerable<model.User> Users { get; set; }

        public async Task OnGet()
        {
            Users = await _db.User.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var User = await _db.User.FindAsync(id);

            if (User == null)
            {
                return NotFound();
            }
            _db.User.Remove(User);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
