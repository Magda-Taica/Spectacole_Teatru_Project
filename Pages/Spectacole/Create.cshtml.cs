#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Spectacole_Teatru_Project.Data;
using Spectacole_Teatru_Project.Models;

namespace Spectacole_Teatru_Project.Pages.Spectacole
{
    public class CreateModel : PageModel
    {
        private readonly Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext _context;

        public CreateModel(Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["RegizorID"] = new SelectList(_context.Set<Regizor>(), "ID", "Nume_Regizor");
            return Page();
        }

        [BindProperty]
        public Spectacol Spectacol { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Spectacol.Add(Spectacol);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
