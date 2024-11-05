using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases.Create;

public interface ICreateCompanyStorage
{
    public Task<CompanyDto> CreateAsync(string name, CancellationToken cancellationToken);
}
