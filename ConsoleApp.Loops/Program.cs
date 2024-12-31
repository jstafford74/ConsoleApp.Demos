// Simple For Loop Demo

// Print Hello World 10 times
//Console.WriteLine("How many times would you like to print 'Hello World'?");
//int times = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < times; i++)
//{
//    Console.WriteLine($"Hello World - {i + 1}");
//}

// While Loop
Console.WriteLine("*********************While Loop*********************");
Console.WriteLine("How many times would you like to print 'Hello World'?");
int times = Convert.ToInt32(Console.ReadLine());
int counter = 0;
while (counter < times)
{
    Console.WriteLine($"Hello World - {counter + 1}");
    counter++;
}
int sum = 0;
int num = 0;

while(num != -1)
{
    Console.Write("Please enter number to be summed up. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    if(num!= -1)
    {
        sum += num;
    }
   
}
Console.WriteLine($"The sum of the numbers entered is {sum}");
Console.WriteLine("*****************End While Loop*********************");

// Do While Loop
Console.WriteLine("*********************Do While Loop*********************");
sum = 0;
num = 0;

do
{
    Console.Write("Please enter number to be summed up. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
    }
}
while (num != -1);
Console.WriteLine($"The sum of the numbers entered is {sum}");
Console.WriteLine("*****************End Do While Loop*********************");

/*
 * ===============Keywords=================
 * Increment: count by static value (++ operator)
 * Accumulate: add up values (compound assignments)
 * Scope: Lifetime of the variable
 * Iteration: Each time the loop repeats
 * Nested: Having control structure inside another control structure
 * break: syntax used to stop statements in a control structure. 
 *          - Used in switch...case statements
 *          - Can be used in loopes to break iteration.
 * continue - syntax to skip over lines and fast-forward to the end of the code block. Can be used in loops to skip iteration.
 * 
 */