namespace MyVaccine.WebApi.Models;
public class Dependent
{
    public int DependentId { get; set; }
    public required string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public required List<VaccineRecord> VaccineRecords { get; set; }

}
