// See https://aka.ms/new-console-template for more information

// Different Data Types
/*
 * Text: strings
 * Integers: int
 * Decimals (precision): double, float, decimal(most precise)
 * Logical: bool
 */

string name = "Jeremiah Stafford";
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the name {0}",name); // Formatted String

int age = 50;
int retirementYearsLeft = 15;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine("My age is " + age);
Console.WriteLine("My retirement age is " + retirementAge);

bool isRetired = true;

if (isRetired)
{
    Console.WriteLine(name + "is retired");
}
