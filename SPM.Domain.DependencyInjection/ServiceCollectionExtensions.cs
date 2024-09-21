using Microsoft.Extensions.DependencyInjection;
using SPM.Domain.UseCases.CompanyUseCases;

namespace SPM.Domain.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainDI(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateCompanyCase, CreateCompanyCase>()
            ;

        return services;
    }
}
