using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Reflection.Emit;

namespace ZippySip.Models
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.HasOne(c => c.Category)
                      .WithMany(d => d.Drinks)
                      .HasForeignKey(c => c.CategoryId);
            });
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasOne(od => od.Order)
                      .WithMany(o => o.OrderDetails)
                      .HasForeignKey(od => od.OrderId)
                      .OnDelete(DeleteBehavior.Cascade); // optional, but usually logical
            });
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasOne(od => od.Drink)
                      .WithMany() // Drink doesn't have navigation to OrderDetails
                      .HasForeignKey(od => od.DrinkId)
                      .OnDelete(DeleteBehavior.Restrict); // important to avoid circular cascade deletes
            });
        }
    }
}
