using CustomDrink.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace CustomDrink.Web
{
    internal static class DependencyInjectionExtention
    {
        internal static IServiceCollection InjectContext(this IServiceCollection services) =>
            services.AddDbContext<CustomDrinkContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "InMem");
            });
    }
}
