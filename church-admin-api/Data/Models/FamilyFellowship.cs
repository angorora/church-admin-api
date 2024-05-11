using System.ComponentModel.DataAnnotations;
using Data.Models;

public class FamilyFellowship
{
     [Key]
    public int Id { get; set;}
    public required string Name { get; set; }
    public required Congregant Leader { get; set; }
    public required List<Congregant> Members { get; set; }
    public Address? Venue { get; set; }
}