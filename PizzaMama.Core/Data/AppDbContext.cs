using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaMama.Core.Models;
using PizzaMama.Core.Models.Identity;

namespace PizzaMama.Core.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relation One-to-Many entre Categorie et Pizza
            modelBuilder.Entity<Pizza>()
                .HasOne(p => p.Categorie)
                .WithMany(c => c.Pizzas)
                .HasForeignKey(p => p.CategorieId);

            // Configuration Many-to-Many entre Pizza et Ingredient
            modelBuilder.Entity<PizzaIngredient>()
                .HasKey(pi => new { pi.PizzaId, pi.IngredientId });

            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Pizza)
                .WithMany(p => p.PizzaIngredients)
                .HasForeignKey(pi => pi.PizzaId);

            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.PizzaIngredients)
                .HasForeignKey(pi => pi.IngredientId);
        }
    }
}