using SPM.Domain.ModelDto;
using SPM.Domain.UseCases.CompanyUseCases;
using SPM.Storage.Context;

namespace SPM.Storage.Storages.CompanyStorages;

public class CreateCompanyStorage(DbSPMContext dbContext, IGuidFactory guidFactory) : ICreateCompanyStorage
{
    public Task<CompanyDto> CreateAsync(string name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
