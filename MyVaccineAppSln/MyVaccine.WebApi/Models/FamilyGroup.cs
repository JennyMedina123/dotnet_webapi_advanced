namespace MyVaccine.WebApi.Models;
public class FamilyGroup : BaseTable
{
    public int FamilyGroupId { get; set; }
    public required string Name { get; set; }
    public required List<User> Users { get; set; }
}