using System;
using System.Collections.Generic;

// 定义一个接口，包含计算面积的方法
public interface IShape
{
    double CalculateArea();
}

// 长方形类
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// 正方形类
public class Square : IShape
{
    public double Side { get; set; }

    public double CalculateArea()
    {
        return Side * Side;
    }
}

// 三角形类
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

// 简单工厂类
public class ShapeFactory
{
    public IShape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "rectangle":
                return new Rectangle();
            case "square":
                return new Square();
            case "triangle":
                return new Triangle();
            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }
}

class Program
{
    static void Main()
    {
        var factory = new ShapeFactory();
        var random = new Random();
        var shapes = new List<IShape>();

        for (int i = 0; i < 10; i++)
        {
            var randomShape = random.Next(1, 4); // Generate random shape type
            IShape shape;

            switch (randomShape)
            {
                case 1:
                    shape = factory.CreateShape("rectangle");
                    ((Rectangle)shape).Width = random.NextDouble() * 10;
                    ((Rectangle)shape).Height = random.NextDouble() * 10;
                    break;
                case 2:
                    shape = factory.CreateShape("square");
                    ((Square)shape).Side = random.NextDouble() * 10;
                    break;
                case 3:
                    shape = factory.CreateShape("triangle");
                    ((Triangle)shape).Base = random.NextDouble() * 10;
                    ((Triangle)shape).Height = random.NextDouble() * 10;
                    break;
                default:
                    throw new ArgumentException("Invalid shape type.");
            }

            shapes.Add(shape);
        }

        double totalArea = 0;
        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
        }

        Console.WriteLine($"Total area of 10 random shapes: {totalArea}");
    }
}

