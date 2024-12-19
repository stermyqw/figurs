using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurs
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(4);
            Console.WriteLine($"Квадрат - Площадь: {square.Area()}, Периметр: {square.Perimeter()}");

            Shape rectangle = new Rectangle(3, 5);
            Console.WriteLine($"Прямоугольник - Площадь: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");

            Shape circle = new Circle(2);
            Console.WriteLine($"Круг - Площадь: {circle.Area():F2}, Периметр: {circle.Perimeter():F2}");
        }
    }

}
