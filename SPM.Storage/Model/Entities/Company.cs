using System.ComponentModel.DataAnnotations;

namespace SPM.Storage.Model.Entities;

public class Company
{
    public Guid CompanyId { get; set; }

    [MaxLength(30)]
    public Guid NameCompany { get; set; }

    public IEnumerable<Department>? Departments { get; set; }
}
