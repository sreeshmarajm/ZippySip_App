using Microsoft.AspNetCore.Mvc;
using ZippySip.Interfaces;
using ZippySip.Models;
using ZippySip.ViewModels;

namespace ZippySip.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Smoothie", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks
                        .Where(p => p.Category.CategoryName.Equals("Smoothie"))
                        .OrderBy(p => p.Name);
                }
                else if (string.Equals("Juice", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks
                        .Where(p => p.Category.CategoryName.Equals("Juice"))
                        .OrderBy(p => p.Name);
                }
                else
                {
                    drinks = _drinkRepository.Drinks
                        .Where(p => p.Category.CategoryName.Equals("Hot Drinks"))
                        .OrderBy(p => p.Name);
                }


                currentCategory = _category;
            }

            return View(new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            });
        }
    }
}
