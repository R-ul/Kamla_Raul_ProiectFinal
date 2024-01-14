using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_ProiectFinal.Data;
using Kamla_Raul_ProiectFinal.Model;

namespace Kamla_Raul_ProiectFinal.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext _context;

        public DeleteModel(Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.Id == id);

            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }
            var author = await _context.Author.FindAsync(id);

            if (author != null)
            {
                Author = author;
                _context.Author.Remove(Author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
