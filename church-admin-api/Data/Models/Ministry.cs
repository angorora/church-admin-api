using System.ComponentModel.DataAnnotations;

public class Ministry
{
     [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

   
}