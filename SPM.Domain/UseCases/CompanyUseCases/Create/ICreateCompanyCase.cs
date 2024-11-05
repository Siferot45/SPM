using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases.Create;

public interface ICreateCompanyCase
{
    Task<CompanyDto> Execute(string name, CancellationToken cancellationToken);
}
