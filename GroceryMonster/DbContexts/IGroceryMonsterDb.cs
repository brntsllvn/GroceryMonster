using System;
using System.Linq;

namespace GroceryMonster.DbContexts
{
    public interface IGroceryMonsterDb : IDisposable
    {
        IQueryable<T> Query<T>() where T : class; 
    }
}
