using System;
using GroceryMonster.Entities;
using GroceryMonster.DbContexts;

namespace GroceryMonster.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private IngredientDbContext _db;

        public IngredientRepository(IngredientDbContext db)
        {
            _db = db;
        }

        public Ingredient Get(int Id)
        {
            return _db.Ingredients.Find(Id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}