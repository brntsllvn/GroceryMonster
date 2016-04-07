
using GroceryMonster.Entities;
using System.Data.Entity;

namespace GroceryMonster.DbContexts
{
    public class IngredientDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}