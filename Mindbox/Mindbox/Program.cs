namespace Mindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Circle circle = new Circle(5);
            Console.WriteLine(circle.GetArea());

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.IsRightTriangle());

            Console.WriteLine();
            Console.WriteLine(GetAreaCompileTime(circle));
            Console.WriteLine(GetAreaCompileTime(triangle));
        }

        static double GetAreaCompileTime(Shape shape)
        {
            return shape.GetArea();
        }
    }
}