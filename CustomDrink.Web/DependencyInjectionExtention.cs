using CustomDrink.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using CustomDrink.Common.ClassHelpers;

namespace CustomDrink.Web
{
    internal static class DependencyInjectionExtention
    {
        internal static IServiceCollection InjectContext(this IServiceCollection services) =>
            services.AddDbContext<CustomDrinkContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "InMem");
            });

        internal static IServiceCollection InjectFluentValidation(this IServiceCollection services) =>
           services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<StoreValidations>());
    }
}
