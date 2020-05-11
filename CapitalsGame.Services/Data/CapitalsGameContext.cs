using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CapitalsGame.Model;

namespace CapitalsGame.Services.Data
{
   public class CapitalsGameContext:DbContext

    {
        public CapitalsGameContext(DbContextOptions<CapitalsGameContext> options)
        : base(options)
        { }

        public DbSet<Country> Country { get; set; }
        public DbSet<Capital> Capital { get; set; }
        public DbSet<Continent> Continent { get; set; }
    }
}
