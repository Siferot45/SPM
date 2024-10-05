using FluentAssertions;
using Moq;
using SPM.Domain.ModelDto;
using SPM.Domain.UseCases.CompanyUseCases;

namespace SPM.Domain.Tests.CompanyTests;

public class CreateCompanyCaseShould
{
    private Mock<ICreateCompanyStorage> _storage;
    private readonly CreateCompanyCase sut;

    public CreateCompanyCaseShould()
    {
        _storage = new Mock<ICreateCompanyStorage>();
        sut = new CreateCompanyCase(_storage.Object);
    }
    [Fact]
    public async Task ReturnCreateCompany()
    {
        var expected = new CompanyDto();

        var actual = await sut.Execute("Hello world", CancellationToken.None);
        actual.Should().Be(expected);

        _storage.Verify(s => s.CreateAsync("Hello world", It.IsAny<CancellationToken>()));

    }
}
