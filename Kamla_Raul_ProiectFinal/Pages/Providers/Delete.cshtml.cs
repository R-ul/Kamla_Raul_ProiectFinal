using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_ProiectFinal.Data;
using Kamla_Raul_ProiectFinal.Model;

namespace Kamla_Raul_ProiectFinal.Pages.Providers
{
    public class DeleteModel : PageModel
    {
        private readonly Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext _context;

        public DeleteModel(Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Provider Provider { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Provider == null)
            {
                return NotFound();
            }

            var provider = await _context.Provider.FirstOrDefaultAsync(m => m.Id == id);

            if (provider == null)
            {
                return NotFound();
            }
            else 
            {
                Provider = provider;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Provider == null)
            {
                return NotFound();
            }
            var provider = await _context.Provider.FindAsync(id);

            if (provider != null)
            {
                Provider = provider;
                _context.Provider.Remove(Provider);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
