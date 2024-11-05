using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases.Get;

public class GetCompanyCase(IGetCompanyStorage companyStorage) : IGetCompanyCase
{
    private readonly IGetCompanyStorage _companyStorage = companyStorage;

    public Task<IEnumerable<CompanyDto>> GetAllAsync(CancellationToken cancellationToken) =>
        _companyStorage.GetCompanyStorageAsync(cancellationToken);
}
