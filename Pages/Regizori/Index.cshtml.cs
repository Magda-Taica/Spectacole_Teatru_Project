﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Spectacole_Teatru_Project.Data;
using Spectacole_Teatru_Project.Models;

namespace Spectacole_Teatru_Project.Pages.Regizori
{
    public class IndexModel : PageModel
    {
        private readonly Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext _context;

        public IndexModel(Spectacole_Teatru_Project.Data.Spectacole_Teatru_ProjectContext context)
        {
            _context = context;
        }

        public IList<Regizor> Regizor { get;set; }

        public async Task OnGetAsync()
        {
            Regizor = await _context.Regizor.ToListAsync();
        }
    }
}
