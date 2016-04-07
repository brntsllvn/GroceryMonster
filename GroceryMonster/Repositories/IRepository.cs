using GroceryMonster.Entities;
using System;

namespace GroceryMonster.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        T Get(int Id);
    }
}