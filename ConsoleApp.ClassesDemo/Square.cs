namespace ConsoleApp.ClassesDemo
{
    public class Square : Polygon 
    {
        public Square(double width)
        {
            Width = width;
        }
        public override double Area()
        {
            return Convert.ToInt32(Math.Pow(Width,2));
        }
    }
}
