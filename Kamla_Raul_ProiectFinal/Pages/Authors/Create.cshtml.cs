﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kamla_Raul_ProiectFinal.Data;
using Kamla_Raul_ProiectFinal.Model;

namespace Kamla_Raul_ProiectFinal.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext _context;

        public CreateModel(Kamla_Raul_ProiectFinal.Data.Kamla_Raul_ProiectFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Author == null || Author == null)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
