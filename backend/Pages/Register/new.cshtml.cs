// model.register.new.C#....................................

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
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContetxt _db;
        public List<SelectListItem> AllUserList = new List<SelectListItem>();
        public List<SelectListItem> AllWorkshopList = new List<SelectListItem>();
        public NewModel(ApplicationDbContetxt db)
        {
            _db = db;
            CreateUserListView();
            CreateWorkshopListView();
        }

        [BindProperty]
        public model.Register Allreg { get; set; }
        
        public async Task<IActionResult> OnPost()
        {
            

            if (ModelState.IsValid)
            {
                await _db.Register.AddAsync(Allreg);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
        public async Task OnGet()
        {
            
        }

        private void CreateUserListView()
        {
            foreach (model.User user in _db.User)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = user.UserName,
                    Value = user.UserId.ToString(),
                    Selected = false
                };
                AllUserList.Add(selectList);
            }

            ItemsViewModel UserViewModel = new ItemsViewModel()
            {
                Items = AllUserList
            };
        }
        private void CreateWorkshopListView()
        {
            foreach (model.Workshop workshop in _db.Workshop)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = workshop.WorkshopName,
                    Value = workshop.WorkshopId.ToString(),
                    Selected = false
                };
                AllWorkshopList.Add(selectList);
            }

            ItemsViewModel UserViewModel = new ItemsViewModel()
            {
                Items = AllWorkshopList
            };
        }
    }
}
