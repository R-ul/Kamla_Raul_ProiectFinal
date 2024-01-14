using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_ProiectFinal.Data;
using Kamla_Raul_ProiectFinal.Model;

namespace Kamla_Raul_ProiectFinal.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext _context;

        public DetailsModel(Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext context)
        {
            _context = context;
        }

      public Game Game { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            else 
            {
                Game = game;
            }
            return Page();
        }
    }
}
