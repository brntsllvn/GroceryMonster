using GroceryMonster.Entities;
using System.Data.Entity;
using System.Linq;

namespace GroceryMonster.DbContexts
{
    public class GroceryMonsterDb : DbContext, IGroceryMonsterDb
    {
        public GroceryMonsterDb()
        {
            
        }

        public DbSet<Ingredient> Ingredients { get; set; }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }
    }
}