using SPM.Domain.ModelDto;

namespace SPM.Domain.UseCases.CompanyUseCases;

public class CreateCompanyCase() : ICreateCompanyCase
{
    public async Task<CompanyDto> Execute(string name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
