using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using SPM.Storage.Storages;
using SPM.Storage.Storages.CompanyStorages;
using SPM.Storage.Tests.Fixture;

namespace SPM.Storage.Tests.CompanyTests;

public class CreateCompanyStorageShould : IClassFixture<StorageTestFixture>
{
    private readonly StorageTestFixture _fixture;
    private readonly CreateCompanyStorage _sut;

    public CreateCompanyStorageShould(StorageTestFixture fixture)
    {
        _fixture = fixture;
        _sut = new CreateCompanyStorage(_fixture.GetDbContext(), new GuidFactory());
    }
    //Todo: возврат созданного обьекта
    [Fact]
    public async Task InsertNewCompanyInDatabase()
    {
        var company = await _sut.CreateAsync("Name company", CancellationToken.None);
        company.Id.Should().NotBeEmpty();

        await using var dbContext = _fixture.GetDbContext();
        var companyTitles = await dbContext.Companies
            .Where(f => f.CompanyId == company.Id)
            .Select(f => f.NameCompany).ToArrayAsync();

        companyTitles.Should().HaveCount(1).And.Contain("Name company");
    }
}
