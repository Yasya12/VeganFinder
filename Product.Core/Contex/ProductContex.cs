using Microsoft.EntityFrameworkCore;
using Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Products.Core.Contex
{
    public class ProductContex : DbContext
    {
        public DbSet<Xavchik> Products => Set<Xavchik>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<User> Users => Set<User>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Xavchik>()
           .Property(x => x.verify)
           .HasDefaultValue('F');
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-667O8U7\\SQLEXPRESS;Database=products_tracker;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
