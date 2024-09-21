using SPM.Domain.UseCases.CompanyUseCases;

namespace SPM.Domain.Tests.CompanyTests;

public class CreateCompanyCaseShould
{
    private readonly CreateCompanyCase sut;

    public CreateCompanyCaseShould()
    {
        sut = new CreateCompanyCase();
    }
    [Fact]
    public async Task ReturnCreateCompany()
    {

    }
}
