using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases;

public interface ICreateCompanyStorage
{
    public Task<CompanyDto> CreateAsync(string name, CancellationToken cancellationToken);
}
