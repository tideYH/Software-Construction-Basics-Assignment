using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework31
{
    public interface Shape
    {
        double CalculateArea();
        bool IsValid();
    }

    public class Rectangle : Shape
    {
        public double length {  get; set; }
        public double width {  get; set; }
        public double CalculateArea()
        {
            return length*width;
        }
        public bool IsValid() {
            if (length>0&&width>0) {  return true; }
            return false;
        }
    }

    public class Square : Shape
    {
        public double side { get; set; }
        public double CalculateArea()
        {
            return side * side;
        }
        public bool IsValid()
        {
            if (side > 0) { return true; }
            return false;
        }
    }

    public class Triangle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * p);
        }

        public bool IsValid()
        {
            return a + b > c & b + c > a & a + c > b;
        }
    }

    class Program
    {
        static void Main()
        {
            // 示例用法
            var rectangle = new Rectangle { width = 5, length = 3 };
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            

            var square = new Square { side = 4 };
            Console.WriteLine($"Square Area: {square.CalculateArea()}");

            var triangle = new Triangle { a = 3, b = 4, c = 5 };
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
            if (triangle.IsValid())
            {
                Console.WriteLine("三角形合法");
            }
            else
            {
                Console.WriteLine("三角形不合法");
            }

        }
    }

}

