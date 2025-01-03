
using ConsoleApp.ClassesDemo.utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Teacher : Person
{
    public void GenerateIdNumber()
    {

        _idNumber = PersonHelper.GenerateIdNumber("TCH");

    }
}
