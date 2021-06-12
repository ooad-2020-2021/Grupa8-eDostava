using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eDostava.Models;

namespace eDostava.Data
{
    public class eDostavaContext : DbContext
    {
        public eDostavaContext (DbContextOptions<eDostavaContext> options)
            : base(options)
        {
        }

        public DbSet<eDostava.Models.Proizvod> Proizvod { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
        }
    }
}
