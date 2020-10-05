using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace backend.model
{
    public class ItemsViewModel
    {
        public IEnumerable<string> SelectedItems { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
    }
}
