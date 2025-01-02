using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (Width * 2) + (Height * 2);
        }
    }
}
