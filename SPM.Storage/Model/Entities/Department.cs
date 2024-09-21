using System.ComponentModel.DataAnnotations;

namespace SPM.Storage.Model.Entities;

public class Department
{
    public Guid DepartmentId { get; set; }

    [MaxLength(30)]
    public string NameDepartment { get; set; }

    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    
    public Guid? AddressId { get; set; }
    public Address? Address { get; set; }

    public IEnumerable<Employee>? Employees { get; set; }
}
