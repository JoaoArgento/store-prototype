using Catalog.Shared.Infra;
using Catalog.Shared.Mappings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDbContext>(options =>
            {
            });

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            services.AddAutoMapper((config) =>
            {
                config.AddProfile<CatalogMappingProfile>();
            });

            return services;
        }
    }
}
