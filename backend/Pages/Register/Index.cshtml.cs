// model.register.index.C#....................................

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using backend.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace backend.Pages.register
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContetxt _db;

        public IndexModel(ApplicationDbContetxt db)
        {
            _db = db;
            
        }

        public IEnumerable<model.Register> AllReg { get; set; }
       
        public async Task OnGet()
        {
            AllReg = await _db.Register.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var reg = await _db.Register.FindAsync(id);

            if (reg == null)
            {
                return NotFound();
            }
            _db.Register.Remove(reg);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

       
       
    }
}
