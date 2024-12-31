

Console.Write("Please enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
/*
   Math Operations and operators
 */

// Addition
int sum = num1 + num2;
// Subtraction
int difference = num1 - num2;
// Multiply
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Modulus
int mod = num1 % num2;
Console.WriteLine("***********************Math Results***********************");
Console.WriteLine();
Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
Console.WriteLine($"The difference of {num1} and {num2} is {difference}");
Console.WriteLine($"The product of {num1} and {num2} is {product}");
Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}");
Console.WriteLine($"The modulus of {num1} and {num2} is {mod}");
Console.WriteLine();
Console.WriteLine("*******************End Math Results***********************");
Console.WriteLine();

/*
   Logic operations and operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;

Console.WriteLine("***********************Logic Results***********************");
Console.WriteLine();
Console.WriteLine($"Is {num1} greater than {num2}? {isGreaterThan}");
Console.WriteLine($"Is {num1} less than {num2}? {isLessThan}");
Console.WriteLine($"Is {num1} equal to {num2}? {isEqual}");
Console.WriteLine($"Is {num1} not equal to {num2}? {isNotEqual}");
Console.WriteLine($"Is {num1} greater than or equal to {num2}? {isGreaterThanOrEqual}");
Console.WriteLine($"Is {num1} less than or equal to {num2}? {isLessThanOrEqual}");
Console.WriteLine();
Console.WriteLine("*******************End Logic Results***********************");
Console.WriteLine();

/*
   Assignment operations and operators
 */
Console.Write("Please enter a random number:");
int randomNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***********************Assignment Results***********************");
Console.WriteLine();
num1 += randomNumber;
Console.WriteLine($"The value of num1 after adding {randomNumber} is {num1}");
num1 -= randomNumber;
Console.WriteLine($"The value of num1 after subtracting {randomNumber} is {num1}");
num1 /= randomNumber;
Console.WriteLine($"The value of num1 after dividing by {randomNumber} is {num1}");
num1 %= randomNumber;
Console.WriteLine($"The value of num1 after taking the modulus of {randomNumber} is {num1}");
num1 *= randomNumber;
Console.WriteLine($"The value of num1 after multiplying by {randomNumber} is {num1}");
Console.WriteLine();
Console.WriteLine("*******************End Assignment Results***********************");