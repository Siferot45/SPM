using Microsoft.EntityFrameworkCore;
using SPM.Domain.ModelDto;
using SPM.Domain.UseCases.CompanyUseCases.Get;
using SPM.Storage.Context;

namespace SPM.Storage.Storages.CompanyStorages;

public class GetCompanyStorage(DbSPMContext dbContext) : IGetCompanyStorage
{
    private readonly DbSPMContext _dbContext = dbContext;

    public async Task<IEnumerable<CompanyDto>> GetCompanyStorageAsync(
        CancellationToken cancellationToken) =>

        await _dbContext.Companies.Select(c => new CompanyDto
        {
            Id = c.CompanyId,
            Name = c.NameCompany
        })
        .ToArrayAsync(cancellationToken);
}

