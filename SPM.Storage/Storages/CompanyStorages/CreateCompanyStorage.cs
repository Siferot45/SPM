using SPM.Domain.ModelDto;
using SPM.Domain.UseCases.CompanyUseCases;
using SPM.Storage.Context;
using SPM.Storage.Model.Entities;

namespace SPM.Storage.Storages.CompanyStorages;

public class CreateCompanyStorage(DbSPMContext dbContext, IGuidFactory guidFactory) : ICreateCompanyStorage
{
    private readonly DbSPMContext _dbContext = dbContext;
    private readonly IGuidFactory _guidFactory = guidFactory;

    public async Task<CompanyDto> CreateAsync(string name, CancellationToken cancellationToken)
    {
        var companyId = _guidFactory.Create();

        var company = new Company
        {
            CompanyId = companyId,
            NameCompany = name,
        };

        await _dbContext.Companies.AddAsync(company, cancellationToken).ConfigureAwait(false);
        await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        //TODO подхачить
        return new CompanyDto(companyId, name);
    }
}
