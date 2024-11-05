using Microsoft.AspNetCore.Mvc;
using SPM.Domain.UseCases.CompanyUseCases.Create;
using SPM.Domain.UseCases.CompanyUseCases.Get;
using SPM.Web.ModelDto.CompanyDto;

namespace SPM.Web.Controller;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    [HttpGet(Name = nameof(GetCompanies))]
    public async Task<IActionResult> GetCompanies(
        [FromServices] IGetCompanyCase companyCase,
        CancellationToken cancellationToken)
    {
        var companies = await companyCase.GetAllAsync(cancellationToken);

        return Ok(companies.Select(c => new CompanyDto
        {
            Id = c.Id,
            Name = c.Name,
        }));
    }
    [HttpPost]
    public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyDto companyDto,
        [FromServices] ICreateCompanyCase companyCase, CancellationToken cancellationToken)
    {
        var company = await companyCase.Execute(companyDto.Name, cancellationToken);

        return CreatedAtRoute(nameof(GetCompanies), new CompanyDto 
        {
            Name = company.Name 
        });
    }
}
