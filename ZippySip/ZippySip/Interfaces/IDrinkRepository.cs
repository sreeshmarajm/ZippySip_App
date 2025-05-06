using ZippySip.Models;

namespace ZippySip.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks {  get; }
        Drink GetDrinkById(int drinkId);
    }
}
