using System.ComponentModel.DataAnnotations;

namespace SPM.Storage.Model.Entities;

public class Address
{
    public Guid AddressId { get; set; }

    [MaxLength(30)]
    public string Sity { get; set; }

    [MaxLength(30)]
    public string Street { get; set; }
}
