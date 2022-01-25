#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spectacole_Teatru_Project.Data;
using Spectacole_Teatru_Project.Models;

namespace Spectacole_Teatru_Project.Pages.Spectacole
{
    public class EditModel : PageModel
    {
        private readonly Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext _context;

        public EditModel(Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Spectacol Spectacol { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spectacol = await _context.Spectacol.FirstOrDefaultAsync(m => m.ID == id);

            if (Spectacol == null)
            {
                return NotFound();
            }
            ViewData["RegizorID"] = new SelectList(_context.Set<Regizor>(), "ID", "Nume_Regizor");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Spectacol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpectacolExists(Spectacol.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SpectacolExists(int id)
        {
            return _context.Spectacol.Any(e => e.ID == id);
        }
    }
}
