public class Person
{
    required public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    required public string LastName { get; init; }
}

var person = new Person { FirstName = "Tracy" };