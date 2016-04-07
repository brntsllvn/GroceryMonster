using GroceryMonster.DbContexts;
using GroceryMonster.Repositories;
using System.Web.Mvc;

namespace GroceryMonster.Controllers
{
    public class IngredientController : Controller
    {
        private IngredientRepository _ingredientRepository;

        public IngredientController(IngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;    
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Detail(int ingredientId)
        {
            var ingredient = _ingredientRepository.Get(ingredientId); 
            return View(ingredient);
        }
    }
}