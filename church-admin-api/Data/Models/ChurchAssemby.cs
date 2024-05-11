using System.ComponentModel.DataAnnotations;

public class ChurchAssembly
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}