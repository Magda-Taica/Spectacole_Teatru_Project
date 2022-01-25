#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spectacole_Teatru_Project.Models;

namespace Spectacole_Teatru_Project.Data
{
    public class Spectacole_Teatru_ProjectContext : DbContext
    {
        public Spectacole_Teatru_ProjectContext (DbContextOptions<Spectacole_Teatru_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Spectacole_Teatru_Project.Models.Spectacol> Spectacol { get; set; }

        public DbSet<Spectacole_Teatru_Project.Models.Regizor> Regizor { get; set; }
    }
}
