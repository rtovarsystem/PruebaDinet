using System.Collections.Generic;
using System.Reflection.Emit;
using DinetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DinetApi.AppBDContext
{
    public class ApplicationBDContext : DbContext
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options)
            : base(options)
        {
        }
        public DbSet<Productos> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
