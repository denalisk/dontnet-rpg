using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShantyShack.Models
{
    public class ShantyShackDbContext: IdentityDbContext<ApplicationUser>
    {
        public ShantyShackDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShantyShackDb;integrated security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<InventoryItem>().HasKey(x => new { x.CharacterId, x.ItemId });
        }
        public DbSet<Character> Characters;
        public DbSet<Item> Items;
        public DbSet<Profile> Profiles;
        public DbSet<Perks> Perks;
        public DbSet<InventoryItem> InventoryItems;

    }
}
