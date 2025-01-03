// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("*************** - Classes and Objects - *****************");

// Define an object of type Person.
Person person;
Person baby = new Person() { FirstName = string.Empty, LastName = string.Empty};

baby.LastName = "Thompson";
baby.FirstName = "Tom";
baby.DateOfBirth = new DateOnly(2023, 1, 1);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine($"Tax Number: {taxNumber}");

var person1 = new Person("John", "Doe", new DateOnly(1980, 1, 1)) { FirstName = string.Empty, LastName = string.Empty };
var person2 = new Person("Jane", "Doe", "123456") { FirstName = string.Empty, LastName = string.Empty };

person1.PrintFullName();
person1.PrintInitials();
person1.GenerateTaxNumber();
var person1TaxNumber = person1.GetTaxNumber();
Console.WriteLine(person1TaxNumber.ToString());

person2.PrintFullName();
person2.PrintInitials();
person2.GetTaxNumber();

var person2taxNumber = person2.GetTaxNumber();
Console.WriteLine(person2taxNumber.ToString());

var teacher = new Teacher() { FirstName = string.Empty, LastName = string.Empty };
teacher.LastName = "Thompson";
teacher.FirstName = "Tom";
teacher.DateOfBirth = new DateOnly(2023, 1, 1);

teacher.PrintFullName();
teacher.PrintInitials();

teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teacherTaxNumber);

teacher.GenerateIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Student student = new() { FirstName = string.Empty, LastName = string.Empty };
student.LastName = "Thompson";
student.FirstName = "Tom";
student.DateOfBirth = new DateOnly(2023, 1, 1);

student.PrintFullName();
student.PrintInitials();

student.GenerateTaxNumber();
var studentTaxNumber = student.GetTaxNumber();
Console.WriteLine(studentTaxNumber.ToString());

student.GenerateIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

Rectangle rectangle = new Rectangle(25, 35);
var rectangleArea = rectangle.Area();
Console.WriteLine($"The rectangle area is: {rectangleArea}");

Square square = new Square(25);
var squareArea = square.Area();
Console.WriteLine($"The square area is: {squareArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();

Console.WriteLine($"The cuboid area is: {cuboidArea}");
Console.WriteLine($"The cuboid volume is: {cuboidVolume}");
Console.WriteLine($"The cuboid perimeter is: {cuboidPerimeter}");

Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"The sphere circumference is: {sphereCircumference}");
Console.WriteLine($"The sphere volume is: {sphereVolume}");


