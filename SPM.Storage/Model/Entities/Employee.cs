using System.ComponentModel.DataAnnotations;

namespace SPM.Storage.Model.Entities;

public class Employee
{
    public Guid EmployeeId { get; set; }

    [MaxLength(30)]
    public string FirstName { get; set; }

    [MaxLength(30)]
    public string LastName { get; set; }

    [MaxLength(30)]
    public string Patronymic { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
}
