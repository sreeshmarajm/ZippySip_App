using System.ComponentModel.DataAnnotations.Schema;

namespace ZippySip.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Drink> Drinks { get; set; } = new List<Drink>();

    }
}
