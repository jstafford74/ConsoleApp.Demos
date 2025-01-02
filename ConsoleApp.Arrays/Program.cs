// See https://aka.ms/new-console-template for more information
Console.WriteLine("************* - Arrays - *************");

// Tell me how many students and grades to be entered
Console.Write("Enter the number of students: ");
int numberOfStudents = Convert.ToInt32(Console.ReadLine());

// Declare Fixed ize Array
int[] grades = new int[numberOfStudents];
string[] students = new string[numberOfStudents];

// Add values to fixed size array
for (int i = 0; i < numberOfStudents; i++)
{
    Console.Write("Enter the students name: ");
    students[i] =Console.ReadLine();

    Console.Write("Enter grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());

}

// Print values in fixed size array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Declare variable size array
//string[] studentNames = { "Newton", "Joshua", "Steve", "Bob" }; // impractical to use this method for large arrays

//// Add values to fixed size array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("Enter student name: ");
//    studentNames[i] = Console.ReadLine();

//}

// Print values in fixed size array
//Console.WriteLine("The student names you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}