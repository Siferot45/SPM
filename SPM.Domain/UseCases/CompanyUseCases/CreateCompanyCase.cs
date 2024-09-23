using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases;

public class CreateCompanyCase(ICreateCompanyStorage companyStorage) : ICreateCompanyCase
{
    private readonly ICreateCompanyStorage _companyStorage = companyStorage;

    public async Task<CompanyDto> Execute(string name, CancellationToken cancellationToken)
    {
        return await _companyStorage.CreateAsync(name, cancellationToken);
    }
}
