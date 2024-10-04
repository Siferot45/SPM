using Microsoft.AspNetCore.Mvc;
using SPM.Domain.UseCases.CompanyUseCases;
using SPM.Web.ModelDto.CompanyDto;

namespace SPM.Web.Controller;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyDto companyDto,
        [FromServices] ICreateCompanyCase companyCase, CancellationToken cancellationToken)
    {
        var company = await companyCase.Execute(companyDto.Name, cancellationToken);
        return Ok(company);
    }
}
