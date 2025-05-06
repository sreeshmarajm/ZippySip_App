using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZippySip.Interfaces;
using ZippySip.Mocks;
using ZippySip.Models;
using ZippySip.Repositories;

namespace ZippySip.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddScoped<IDrinkRepository,DrinkRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            return services;
        }
    }
}
