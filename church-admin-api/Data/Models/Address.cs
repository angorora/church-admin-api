using System.ComponentModel.DataAnnotations;

public class Address
{
     [Key()]
    public int Id {get; set;}
    public int Number { get; set; }
    public required string StreetName { get; set; }
    public required string Suburb { get; set; }
    public required string City { get; set; }
}