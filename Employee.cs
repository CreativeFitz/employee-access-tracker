

public class Employee {
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Position {get; set;}
    public string Department {get; set;}
    public string AccessLevel {get; set;}

    public Employee (int id, string firstName, string lastName, string position, string department, string accessLevel)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Department = department;
        AccessLevel = accessLevel;
    }

    public void Display()
    {
        Console.WriteLine($"{Id}: {FirstName} {LastName} is a {Position} in {Department}, current AccessLevel is {AccessLevel}");
    }
}