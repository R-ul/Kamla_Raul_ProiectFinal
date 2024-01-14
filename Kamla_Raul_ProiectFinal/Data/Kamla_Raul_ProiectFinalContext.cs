using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_ProiectFinal.Model;

namespace Kamla_Raul_ProiectFinal.Data
{
    public class Kamla_Raul_ProiectFinalContext : DbContext
    {
        public Kamla_Raul_ProiectFinalContext (DbContextOptions<Kamla_Raul_ProiectFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Kamla_Raul_ProiectFinal.Model.Game> Game { get; set; } = default!;

        public DbSet<Kamla_Raul_ProiectFinal.Model.Author>? Author { get; set; }

        public DbSet<Kamla_Raul_ProiectFinal.Model.Provider>? Provider { get; set; }
    }
}
