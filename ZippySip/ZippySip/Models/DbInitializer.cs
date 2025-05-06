namespace ZippySip.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            //AppDbContext context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Acai Superfood Smoothie",
                        Price = 10.25M,
                        ShortDescription = "Nutrient-packed, naturally sweet, and refreshingly fruity.",
                        LongDescription = "A vibrant blend of antioxidant-rich acai berries, bananas, and pomegranate juice for a delicious superfood boost.",
                        Category = Categories["Smoothie"],
                        ImageUrl = "/Images/1.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/1.jpg"
                    },
                    new Drink
                    {
                        Name = "Skinny Almond Joy Smoothie",
                        Price = 9.50M,
                        ShortDescription = "A creamy, chocolatey smoothie made with almonds and a touch of sweetness.",
                        LongDescription = "Satisfy your cravings with this lighter version of the classic Almond Joy, blending almonds, chocolate, and a hint of sweetness.",
                        Category = Categories["Smoothie"],
                        ImageUrl = "/Images/2.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/2.jpg"
                    },
                    new Drink
                    {
                        Name = "Apple Spinach Green Smoothie",
                        Price = 10.50M,
                        ShortDescription = "A vibrant blend of spinach and apples.",
                        LongDescription = "Nourishing and delicious, this apple-spinach smoothie combines green goodness with natural sweetness to fuel your day.",
                        Category = Categories["Smoothie"],
                        ImageUrl = "/Images/20.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/20.jpg"
                    },
                    new Drink
                    {
                        Name = "Avocado Banana Smoothie",
                        Price = 10.95M,
                        ShortDescription = "A creamy, refreshing blend of avocado and banana.",
                        LongDescription = "Savor the smooth, indulgent goodness of avocado and banana in this delicious, nutritious smoothie that’s both satisfying and energizing.",
                        Category = Categories["Smoothie"],
                        ImageUrl = "/Images/4.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/4.jpg"
                    },
                    new Drink
                    {
                        Name = "Banana Bread Smoothie",
                        Price = 11.25M,
                        ShortDescription = "A cozy blend of bananas, oats, and cinnamon.",
                        LongDescription = "A deliciously creamy smoothie that tastes just like your favorite banana bread, perfect for any time of day.",
                        Category = Categories["Smoothie"],
                        ImageUrl = "/Images/5.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/5.jpg"
                    },
                    new Drink
                    {
                        Name = "Orange Juice",
                        Price = 9.95M,
                        ShortDescription = "Freshly squeezed sunshine in every sip!",
                        LongDescription = "Bursting with citrusy goodness, our Orange Juice is a zesty, refreshing classic made from the finest handpicked oranges.",
                        Category = Categories["Juice"],
                        ImageUrl = "/Images/25.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/25.jpg"
                    },
                    new Drink
                    {
                        Name = "Mango Juice",
                        Price = 9.75M,
                        ShortDescription = "Made from ripe, juicy mangoes",
                        LongDescription = "Made from ripe, juicy mangoes — this golden drink delivers smooth, naturally sweet refreshment with every sip.",
                        Category = Categories["Juice"],
                        ImageUrl = "/Images/26.jpg",
                        InStock = false,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/26.jpg"
                    },
                    new Drink
                    {
                        Name = "Carrot Juice",
                        Price = 10.95M,
                        ShortDescription = "Freshly pressed carrots blended into a sweet, earthy juice",
                        LongDescription = "Loaded with vitamin A and antioxidants, our fresh carrot juice is your daily dose of wellness in every sip.",
                        Category = Categories["Juice"],
                        ImageUrl = "/Images/27.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/27.jpg"
                    },
                    new Drink
                    {
                        Name = "Watermelon Juice",
                        Price = 10.75M,
                        ShortDescription = "Naturally sweet and super hydrating",
                        LongDescription = "Freshly blended watermelon in every sip — light, crisp, and bursting with summery sweetness.",
                        Category = Categories["Juice"],
                        ImageUrl = "/Images/28.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/28.jpg"
                    },
                    new Drink
                    {
                        Name = "Apple Juice",
                        Price = 9.95M,
                        ShortDescription = "fresh, fruity, and full of goodness in every drop.",
                        LongDescription = "Naturally sweet, refreshingly crisp — this apple juice is a golden classic that never goes out of style.",
                        Category = Categories["Juice"],
                        ImageUrl = "/Images/29.jpg",
                        InStock = false,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/29.jpg"
                    },
                    new Drink
                    {
                        Name = "Hot Chocolate",
                        Price = 11.00M,
                        ShortDescription = "Your favorite chocolatey indulgence in a cup.",
                        LongDescription = "A warm, velvety hug of cocoa goodness for any cozy moment.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/11.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/11.jpg"
                    },
                    new Drink
                    {
                        Name = "Mexican hot chocolate",
                        Price = 7.95M,
                        ShortDescription = "Rich chocolate with a fiery cinnamon-chili twist.",
                        LongDescription = "A cozy classic with a kick — smooth cocoa meets warm, vibrant spice.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/12.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/12.jpg"
                    },
                    new Drink
                    {
                        Name = "French Hot Chocolate",
                        Price = 8.75M,
                        ShortDescription = "Indulgently thick and rich!",
                        LongDescription = "Decadent dark chocolate melted into silky smooth perfection.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/13.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/13.jpg"
                    },
                    new Drink
                    {
                        Name = "Cappuccino",
                        Price = 9.50M,
                        ShortDescription = "Rich espresso topped with velvety foam.",
                        LongDescription = "Smooth, creamy, and bold — the perfect coffee harmony in every cup.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/14.jpg",
                        InStock = false,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/14.jpg"
                    },
                    new Drink
                    {
                        Name = "Caffe macchiato",
                        Price = 10.50M,
                        ShortDescription = "Bold flavor softened by a dash of milk.",
                        LongDescription = "A strong shot of espresso “stained” with steamed milk for the perfect balance.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/21.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/21.jpg"
                    },
                    new Drink
                    {
                        Name = "Chai Tea",
                        Price = 11.50M,
                        ShortDescription = "Spiced, creamy, and comforting",
                        LongDescription = "Brewed with black tea, milk, and aromatic spices for a soothing, flavorful experience.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/22.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/22.jpg"
                    },
                    new Drink
                    {
                        Name = "Rooibos Tea",
                        Price = 8.45M,
                        ShortDescription = "Naturally caffeine-free with a smooth, earthy flavor.",
                        LongDescription = "Rich in antioxidants and naturally sweet, Rooibos Tea is a wholesome way to relax and unwind.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/23.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/23.jpg"
                    },
                    new Drink
                    {
                        Name = "Herbal Tea",
                        Price = 8.75M,
                        ShortDescription = "Caffeine-free and calming.",
                        LongDescription = "Herbal tea is made from herbs, spices, flowers, or fruits. It’s naturally caffeine-free and perfect for relaxation.",
                        Category = Categories["Hot Drinks"],
                        ImageUrl = "/Images/24.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/24.jpg"
                    }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Smoothie", Description="Blend it. Sip it. Love it." },
                        new Category { CategoryName = "Juice", Description="Freshness in every sip!" },
                        new Category { CategoryName = "Hot Drinks", Description="Warm your soul, one sip at a time." }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}

