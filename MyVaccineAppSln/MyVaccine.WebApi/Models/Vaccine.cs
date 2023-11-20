namespace MyVaccine.WebApi.Models;
public class Vaccine : BaseTable
{
    public int VaccineId { get; set; }
    public required string Name { get; set; }
    public required List<VaccineCategory> Categories { get; set; }
    public bool RequiresBooster { get; set; }
}
