// Declare variables
using System.Globalization;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;                           // initialized at 0
const int retirementAge = 65;
DateOnly dob = new DateOnly();     // initialized at 1/1/0001
decimal salary;                    // initialized at 0
char gender = char.MinValue;
bool working;                      // initialized as false

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (mm/dd/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(),"mm/dd/yyyy",CultureInfo.InvariantCulture);

age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsLeft = retirementAge - age;
var estimatedRetirementYear = DateTime.Now.AddYears(workingYearsLeft).Year;
// Output the results
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working Years Remaining: {workingYearsLeft}");
Console.WriteLine($"Salary: {salary:C}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Are you working: {working}");
Console.WriteLine($"Estimated retirement year: {estimatedRetirementYear}");

