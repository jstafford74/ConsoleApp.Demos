
namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;
public partial class Person
{
    public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }
    public int GetAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public int GetAge(int year)
    {
        return year - DateOfBirth.Year;
    }
}
