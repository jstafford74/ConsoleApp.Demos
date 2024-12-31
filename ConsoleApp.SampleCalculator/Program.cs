// Welcome Message
Console.WriteLine("***** - Welcome to the sample calculator! - ******");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options / Show menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

int choice = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selection option
//if(choice == 1)
//{
//    int sum = num1 + num2;
//    Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
//}
//else if (choice == 2)
//{
//    int difference = num1 - num2;
//    Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
//}
//else if (choice == 3)
//{
//    int product = num1 * num2;
//    Console.WriteLine($"The product of {num1} and {num2} is {product}");
//}
//else if (choice == 4)
//{
//    int quotient = num1 / num2;
//    Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}");
//}
//else
//{
//    Console.WriteLine("Invalid selection");
//}
int answer = 0;

switch (choice)
{
    case 1:
        int sum = num1 + num2;
        answer = sum;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        break;
    case 2:
        int difference = num1 - num2;
        answer = difference;
        Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
        break;
    case 3:
        int product = num1 * num2;
        answer = product;
        Console.WriteLine($"The product of {num1} and {num2} is {product}");
        break;
    case 4:
        int quotient = num1 / num2;
        answer = quotient;
        Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}");
        break;
    default:
        Console.WriteLine("Invalid selection");
        break;
}
// Print global output
Console.WriteLine($"The result is: {answer}");

