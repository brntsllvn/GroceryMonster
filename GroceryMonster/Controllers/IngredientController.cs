using System.Linq;
using GroceryMonster.DbContexts;
using System.Web.Mvc;
using GroceryMonster.Entities;

namespace GroceryMonster.Controllers
{
    public class IngredientController : Controller
    {
        IGroceryMonsterDb _db;

        public IngredientController()
        {
            _db = new GroceryMonsterDb();
        }

        public IngredientController(IGroceryMonsterDb db)
        {
            _db = db;
        }

        public ActionResult Detail(int ingredientId)
        {
            var model = _db.Query<Ingredient>()
                           .Where(i => i.Id == ingredientId);
            return View(model);
        }
    }
}