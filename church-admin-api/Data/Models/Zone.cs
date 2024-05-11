using System.ComponentModel.DataAnnotations;
using Data.Models;

public class Zone
{
     [Key]
    public int Id { get; set;}
    public required string Name { get; set; }
    public required Congregant Leader { get; set; }
    public required List<FamilyFellowship> Fellowships { get; set; }
}