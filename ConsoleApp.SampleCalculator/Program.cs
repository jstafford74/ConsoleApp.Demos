// Welcome Message


// Variable declarations
int choice = 0;
int num1, num2 = 0;


while (choice != -1)
{
    try
    {
        // Show calculator options / Show menu
        PrintMenu();
      
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        // Prompt for user input
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int answer = CalculateNumbers(num1, num2, choice);

        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");  
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }
    finally
    {
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
}



Console.WriteLine("******** - Thank you for using the sample calculator! - *********");

// Method Definitions
void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("***** - Welcome to the sample calculator! - ******");
    Console.WriteLine("Please select an operation (-1 to exit program)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
}

int CalculateNumbers(int num1, int num2, int choice)
{
    int answer = 0;
    switch (choice)
    {
        case 1:
            answer = AddNumbers(num1, num2);
            break;
        case 2:
            answer = SubtractNumbers(num1, num2);
            break;
        case 3:
            answer = MultiplyNumbers(num1, num2);
            break;
        case 4:
            answer = DivideNumbers(num1, num2);
            break;
        case 5:
            answer = GetFibonacciSequence(num1, num2);
            break;
        default:
            throw new Exception("Invalid menu selection");
    }

    return answer;
}

int GetFibonacciSequence(int num1, int num2)
{
    Console.WriteLine("Fibonacci sequence");
    var answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }

    return answer;
}

int DivideNumbers(int num1, int num2)
{
    var quotient = num1 / num2;
    Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}");
    return quotient;
}

int MultiplyNumbers(int num1, int num2)
{
    var product = num1 * num2;
    Console.WriteLine($"The product of {num1} and {num2} is {product}");
    return product;
}

int SubtractNumbers(int num1, int num2)
{
    var diff = num1 - num2;
    Console.WriteLine($"The difference of {num1} and {num2} is {diff}");
    return diff;
}

int AddNumbers(int num1, int num2)
{
    var sum = num1 + num2;
    Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    return sum;
}
