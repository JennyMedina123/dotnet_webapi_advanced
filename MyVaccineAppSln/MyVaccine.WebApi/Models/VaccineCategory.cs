﻿namespace MyVaccine.WebApi.Models;
public class VaccineCategory
{
    public int VaccineCategoryId { get; set; }
    public required string Name { get; set; }
    public required List<Vaccine> Vaccines { get; set; }
}
