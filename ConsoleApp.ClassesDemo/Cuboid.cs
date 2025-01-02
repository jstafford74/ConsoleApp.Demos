namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }
        public double Height { get; set; }
        public double Depth { get; set; }
        public override double Area()
        {
            return (Width * Height) + (Height * Depth) + (Width * Depth);
        }

        public double Perimeter()
        {
            return 4 * (Width + Height + Depth);
        }

        public double Volume()
        {
            return Width * Height * Depth;
        }
    }
}
