using Microsoft.AspNetCore.Mvc;
using SPM.Api.ModelDto;
using SPM.Domain.UseCases.CompanyUseCases;

namespace SPM.Api.Controllers
{
    public class CompanyController : ControllerBase
    {
        [HttpPost("companies")]
        public async Task<IActionResult> CreateCompany(CreateCompany createCompany, [FromServices] ICreateCompanyCase companyCase,
             CancellationToken cancellationToken)
        {
            var company = await companyCase.Execute(createCompany.Name, cancellationToken);
            return Ok(company);
        }
    }
}
