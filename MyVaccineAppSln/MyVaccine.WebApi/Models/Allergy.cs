using System.ComponentModel.DataAnnotations;

namespace MyVaccine.WebApi.Models;
public class Allergy : BaseTable
{
    [Key]
    public int allergiesId { get; set; }
    public string  Name { get; set; }
    public DateTime DateOfAllergy { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
