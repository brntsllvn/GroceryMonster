using System.Collections.Generic;
using System.Linq;
using GroceryMonster.Entities;

namespace GroceryMonster.Tests
{
    class TestData
    {
        public static IQueryable<Ingredient> Ingredients
        {
            get
            {
                var ingredients = new List<Ingredient>();
                for (int i = 0; i < 100; i++)
                {
                    var ingredient = new Ingredient {Id = i, Name = string.Format("Carrot_{0}", i)};
                    ingredients.Add(ingredient);
                }
                return ingredients.AsQueryable();
            }
        } 
    }
}
