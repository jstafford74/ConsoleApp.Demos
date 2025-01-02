// See https://aka.ms/new-console-template for more information
Console.WriteLine("****************** - Methods - ******************");

// void methods - complete a task without returning a value
void PrintName()
{
    Console.WriteLine("Jeremiah Stafford");
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    return DateTime.Now.AddYears(-5).Year;
}
// methods with parameters
void PrintNameWithParams(string name)
{
    Console.WriteLine(name);
}

int GetYearDifference(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}
// methods with optional parameters
int GetFutureOrPastYears(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";

    //}
    //if (!count.HasValue)
    //{
    //    count = 1;
    //}

    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/* Function Calls */
//PrintName();
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine($"Five years ago was: {fiveYearsAgo}");
//Console.WriteLine("Please enter your name");
//string name1 = Console.ReadLine();
//PrintNameWithParams(name1);

//Console.WriteLine("Please enter a year");
//int pastYear = Convert.ToInt32(Console.ReadLine()); 
//int yearsAgo = GetYearDifference(pastYear);
//Console.WriteLine($"{pastYear} was {yearsAgo} years ago.");

//Console.WriteLine("Please enter number of years in future or past");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());
//var pastYear1 = GetFutureOrPastYears();
//Console.WriteLine($"The year is {pastYear1}");
//var pastYear2 = GetFutureOrPastYears(numberOfYears);
//Console.WriteLine($"The year is {numberOfYears}");

PrintNameNullableParam(null, null);
PrintNameNullableParam("Jeremiah", 5);