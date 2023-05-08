namespace Mindbox
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            return Math.Sqrt(((a + b + c) / 2)
                * (((a + b + c) / 2) - a)
                * (((a + b + c) / 2) - b)
                * (((a + b + c) / 2) - c));
        }

        public bool IsRightTriangle()
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
        }
    }
}
