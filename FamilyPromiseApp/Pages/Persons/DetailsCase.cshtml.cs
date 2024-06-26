using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Cases
{
    public class DetailsModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DetailsModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

      public Case Case { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Case == null)
            {
                return NotFound();
            }

            var Case = await _context.Case.FirstOrDefaultAsync(m => m.ID == id);
            if (Case == null)
            {
                return NotFound();
            }
            else 
            {
                // Case = Case;
            }
            return Page();
        }
    }
}
