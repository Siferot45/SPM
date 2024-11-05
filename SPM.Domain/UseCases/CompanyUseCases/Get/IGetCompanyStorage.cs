using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases.Get;

public interface IGetCompanyStorage
{
    Task<IEnumerable<CompanyDto>> GetCompanyStorageAsync(CancellationToken cancellationToken);
}
