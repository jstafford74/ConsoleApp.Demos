// Declare variables
using System.Globalization;
using ConsoleApp.UserInputDemo;

char choice = char.MinValue;
string? firstName = string.Empty;
string lastName = string.Empty;
int age;                           // initialized at 0
DateOnly dob = new DateOnly();     // initialized at 1/1/0001
decimal salary;                    // initialized at 0
char gender = char.MinValue;
bool working;                      // initialized as false

List<Person> persons = new List<Person>();

while (choice != 'E')
{
    // Prompt the user for input
    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (mm/dd/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy", CultureInfo.InvariantCulture);

    age = DateTime.Now.Year - dob.Year;

    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working? (true or false): ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new Person(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);

    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine().ToUpper());

}

foreach (var person in persons)
{
    // Output the results
    Console.WriteLine();
    Console.WriteLine($"Full name: {person.GetFullName()}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Working Years Remaining: {person.GetNumberOfWOrkingYearsRemaining()}");
    Console.WriteLine($"Salary: {person.Salary:C}");
    Console.WriteLine($"Gender: {person.Gender}");
    Console.WriteLine($"Are you working: {person.IsWorking}");
    Console.WriteLine($"Estimated retirement year: {person.GetEstimatedRetirementDate()}");
}

