using Microsoft.AspNetCore.Mvc;
using ZippySip.Interfaces;
using ZippySip.ViewModels;

namespace ZippySip.Controllers
{
    public class DrinkHomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public DrinkHomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new DrinkHomeViewModel
            {
                PrefferedDrinks=_drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}
