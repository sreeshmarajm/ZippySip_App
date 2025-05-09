﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ZippySip.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool? IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
