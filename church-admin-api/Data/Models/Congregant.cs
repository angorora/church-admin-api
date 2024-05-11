

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

public partial class Congregant
{
    private string _firstName;
    private string _surname;

    public Congregant(string firstName, string surname)
    {
        _firstName = firstName;
        _surname= surname;
    }

    public int Id {get; set;}
    public string Name => $"{this._firstName} {this._surname}";
    public required string FirstName { set => _firstName = value; }
    public required string Surname { set => _surname = value; }
    public string? Designation {get; set;} = null;
    public required Address Address {get; set;}

}

