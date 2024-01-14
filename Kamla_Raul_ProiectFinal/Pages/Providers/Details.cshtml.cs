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
    public class DetailsModel : PageModel
    {
        private readonly Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext _context;

        public DetailsModel(Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext context)
        {
            _context = context;
        }

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
    }
}
