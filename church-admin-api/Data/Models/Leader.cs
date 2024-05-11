using Data.Models;

public class Leader : Congregant
{
    public Leader(string firstName, string surname) : base(firstName, surname)
    {
    }

    public required string Position { get; set; }

    public required List<Ministry> Ministry { get; set; }
}