// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail

if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
}
/*
 * A : 86 - 100
 * B:  75 - 85
 * C:  65 - 74
 * D:  50 - 64
 * F:  less than 50
 */
Console.WriteLine("*******************Complex IF.. ELSE IF Statements");
Console.WriteLine();
if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("Student has a D");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("Student has a C");
}
else if (grade >= 75 && grade <= 85)
{
    Console.WriteLine("Student has a B");
}
else if (grade >= 86)
{
    Console.WriteLine("Student has an A");
}

else
{
    Console.WriteLine("Invalid grade");
}
Console.WriteLine("***************End Complex IF.. ELSE IF Statements");

Console.WriteLine("*******************Ternary Result*******************");
Console.WriteLine();
string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Students status: {passStatus}");
Console.WriteLine("***************End Ternary Result*******************");

// Switch statements - used to evaluate a value and take an action
Console.WriteLine("******************************Switch Statement Results******************************");
/*
 * 1- Sunday
 * 2- Monday
 * 3- Tuesday
 * 4- Wednesday (Hump Day!)
 * 5- Thursday
 * 6- Friday (TGIF!!)
 * 7- Saturday (Beach Day!!!)
 */
Console.WriteLine("Please enter a day of the week (1-7): ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday (Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday (TGIF!!)");
        break;
    case 7:
        Console.WriteLine("Saturday (Beach Day!!!)");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}
Console.WriteLine("**************************End Switch Statement Results******************************");