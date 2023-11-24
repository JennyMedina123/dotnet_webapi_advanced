namespace MyVaccine.WebApi.Dtos.Allergy;

public class AllergyRequestDto
{
    public string Name { get; set; }
    public DateTime DateOfAllergy { get; set; }
    public int UserId { get; set; }
}
