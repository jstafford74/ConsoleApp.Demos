using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public class Teacher : Person
    {
        public void GenerateIdNumber()
        {
           
             _idNumber = "TCH-" + GetRandomNumber();

        }
    }
}
