namespace MyVaccine.WebApi.Models;
public class User
{
    public int UserId { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required List<Dependent> Dependents { get; set; }
    public required List<FamilyGroup> FamilyGroups { get; set; }
    public required List<VaccineRecord> VaccineRecords { get; set; }
    public required List<Allergy> Allergies { get; set; }

}

