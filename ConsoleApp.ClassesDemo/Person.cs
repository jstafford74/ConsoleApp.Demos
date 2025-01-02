// See https://aka.ms/new-console-template for more information
// Define a class
using System.Security.Cryptography;

public class Person
{
    public Person() 
    { 
            
    }

    public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }
    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A";

    // Methods
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public void PrintFullName()
    {
        Console.WriteLine(GetFullName());
    }

    public void PrintInitials()
    {
        Console.WriteLine($"{FirstName[0]}.{LastName[0]}.");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandomNumber();
        } else
        {
            Console.WriteLine("Tax number already exists.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public int GetAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public int GetAge(int year)
    {
        return year - DateOfBirth.Year;
    }

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
                 .GetInt32(100000, 999999)
                 .ToString();
    }
}