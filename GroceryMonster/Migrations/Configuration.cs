namespace GroceryMonster.Migrations
{
    using Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GroceryMonster.DbContexts.IngredientDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DbContexts.IngredientDbContext context)
        {
            context.Ingredients.AddOrUpdate(
                i => i.Name,
                new Ingredient { Name = "Broccoli" },
                new Ingredient { Name = "Carrot" },
                new Ingredient { Name = "Ham" }
                );
        }
    }
}
