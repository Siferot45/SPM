using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases.Get;

public interface IGetCompanyCase
{
    Task<IEnumerable<CompanyDto>> GetAllAsync(CancellationToken cancellationToken);
}
