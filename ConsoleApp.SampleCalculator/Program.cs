// Welcome Message
Console.WriteLine("***** - Welcome to the sample calculator! - ******");

// Variable declarations
int choice = 0;
int num1, num2 = 0;
int answer = 0;

while (choice != -1)
{
    try
    {
        // Show calculator options / Show menu
        Console.WriteLine("Please select an operation (-1 to exit program)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");
      
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
            case 5:
                Console.WriteLine("Fibonacci sequence");
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid menu selection");  
        }
        // Print global output
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
