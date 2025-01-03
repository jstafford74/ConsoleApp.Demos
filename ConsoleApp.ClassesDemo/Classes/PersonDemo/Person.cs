// See https://aka.ms/new-console-template for more information
// Define a class
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;
public partial class Person
{
    public Person()
    {

    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }
    // Properties/Data Members
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
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
        }
        else
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


    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
                 .GetInt32(100000, 999999)
                 .ToString();
    }
}

