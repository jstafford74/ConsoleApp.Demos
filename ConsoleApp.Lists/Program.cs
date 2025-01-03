// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** - Lists - *****************");

// Declare a list
List<int> grades = new List<int>();
List<string> students = new List<string>();

int grade = 0;
string name;
int @continue = 1;
int gradeCount = 0;
//var grades = new List<int>();


// Add values to a list
//grades.Add(45);

do
{
    gradeCount += 1;
    Console.Write("Enter the students name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter a grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade != -1)
    {
        grades.Add(grade);
    }

    Console.Write("Do you wish to continue (1 = yes | 2 = no)? ");
    @continue = Convert.ToInt32(Console.ReadLine());

} while (@continue == 1);

// Print values in a list - for
Console.WriteLine("The grades you have entered are(for): ");
for (int i = 0; i < gradeCount; i++)
{

    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Print values in a list - foreach
//Console.WriteLine("The grades you have entered are(for each): ");
//foreach (int item in grades)
//{
//    Console.WriteLine(item);
//}
