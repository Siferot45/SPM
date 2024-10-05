using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SPM.Domain.UseCases.CompanyUseCases;
using SPM.Web.ModelDto.CompanyDto;

namespace SPM.Web.Controller;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllConmanys()
    {
        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyDto companyDto,
        [FromServices] ICreateCompanyCase companyCase, CancellationToken cancellationToken)
    {
        var company = await companyCase.Execute(companyDto.Name, cancellationToken);
        return CreatedAtRoute(nameof(GetAllConmanys), new CompanyDto {Name = company.Name });
    }
}
