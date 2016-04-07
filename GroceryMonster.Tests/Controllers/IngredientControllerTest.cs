using System.Collections;
using GroceryMonster.Controllers;
using GroceryMonster.DbContexts;
using GroceryMonster.Entities;
using GroceryMonster.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GroceryMonster.Tests.Fakes;

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
        public void DetailReturnsNotNull()
        {
            var ingredientController = new IngredientController();

            var result = ingredientController.Detail(42) as ViewResult;
            var model = result.Model;

            Assert.That(model, Is.Not.Null);
        }

        [Test]
        public void DetailPassesInstanceOfIngredientToView()
        {
            // Arrange
            var db = new FakeGroceryMonsterDb();
            db.AddSet(TestData.Ingredients);

            var ingredientController = new IngredientController(db);
            //ingredientController.ControllerContext = new FakeControllerContext();

            // Assert
            var result = ingredientController.Detail(42) as ViewResult;
            IEnumerable<Ingredient> model = result.Model as IEnumerable<Ingredient>;

            // Act
            Assert.AreEqual(1, model.Count());
        }
    }
}
