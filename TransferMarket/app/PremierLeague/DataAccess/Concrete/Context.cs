using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PremierLeague.Entities;

namespace PremierLeague
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID =postgres;Password=Pa$$w0rd!.;Server=localhost;Port=5432;Database=PremierLeague;Integrated Security = true; Pooling = true; ");
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
