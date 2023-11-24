namespace MyVaccine.WebApi.Dtos.Vaccine;

public class VaccineRequestDto
{
    public string Name { get; set; }
    public DateTime DateOfVaccine { get; set; }
    public int UserId { get; set; }
}
