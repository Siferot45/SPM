using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SPM.Domain.UseCases.CompanyUseCases;
using SPM.Storage.Context;
using SPM.Storage.Storages.CompanyStorages;

namespace SPM.Storage.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddStorageDI(this IServiceCollection services, string connectionString)
    {
        services
            .AddScoped<ICreateCompanyStorage, CreateCompanyStorage>()
            ;
        
        services
            .AddDbContext<DbSPMContext>(options =>
            {
                options.UseNpgsql(connectionString);
                options.UseSnakeCaseNamingConvention();
            });

        return services;
    }
}
