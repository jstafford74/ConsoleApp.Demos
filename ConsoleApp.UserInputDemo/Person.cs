namespace ConsoleApp.UserInputDemo
{
    public class Person
    {
        public Person(DateOnly dob)
        {
            _age = DateTime.Now.Year - dob.Year;
            DateOfBirth = dob;
        }
        // Properties/Data Members
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly DateOfBirth { get; init; }
        public decimal Salary { get; set; }

        public char Gender { get; set; }
        public bool IsWorking { get; set; }
        // Field member
        private readonly int _age;

        // Methods
        public int GetNumberOfWOrkingYearsRemaining()
        {
            return Constants.retirementAge - _age;
        }

        public DateOnly GetEstimatedRetirementDate()
        {
            return DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWOrkingYearsRemaining()));
        }
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

        public int GetAge()
        {
            return _age;
        }
    }

}
