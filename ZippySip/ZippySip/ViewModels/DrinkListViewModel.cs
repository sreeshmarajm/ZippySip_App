using ZippySip.Models;

namespace ZippySip.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink>? Drinks { get; set; }
        public string? CurrentCategory { get; set; }
    }
}
