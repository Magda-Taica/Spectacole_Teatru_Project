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

namespace Spectacole_Teatru_Project.Pages.Regizori
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
            return Page();
        }

        [BindProperty]
        public Regizor Regizor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Regizor.Add(Regizor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
