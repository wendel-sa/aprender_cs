using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using aprender_cs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aprender_cs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Op) : base(Op)
        {
            
        }
        public DbSet<Heroi> Heroi { get; set; }
        public DbSet<Batalha> Batalha { get; set; }
        public DbSet<Arma> Arma { get; set; }

        public DbSet<HeroiBatalha> HeroisBaTalhas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=My@eds17;database=HeroApp", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.22-mysql"));
        }*/
    }
}