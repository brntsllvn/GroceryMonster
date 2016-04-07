using GroceryMonster.Controllers;
using GroceryMonster.DbContexts;
using GroceryMonster.Entities;
using GroceryMonster.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GroceryMonster.Tests.Controllers
{
    [TestFixture]
    public class IngredientControllerTest
    {
        //[Test]
        //public void IndexReturnsNotNull()
        //{
        //    // Arrange
        //    var ingredientController = new IngredientController();

        //    // Assert
        //    var result = ingredientController.Index() as ViewResult;

        //    // Act
        //    Assert.That(result, Is.Not.Null);
        //}

        [Test]
        public void DetailPassesInstanceOfIngredientToView()
        {
            // Arrange
            var ingredientContext = new IngredientDbContext();
            var ingredientRepository = new IngredientRepository(ingredientContext);
            var ingredientController = new IngredientController(ingredientRepository);
            var ingredient = new Ingredient { Id = 42, Name = "Spinach" };

            // Assert
            var result = ingredientController.Detail(42) as ViewResult;

            // Act
            Assert.That(result.Model.Equals(ingredient));
        }
    }
}
