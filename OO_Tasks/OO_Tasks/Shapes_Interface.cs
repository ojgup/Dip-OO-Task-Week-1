using System;

namespace OO_Tasks_Interface
{
    public interface IShapeProps
    {
        double GetArea();
        double GetPerimeter();
    }

    public interface ICircleProps
    {
        double GetArea();
        double GetPerimeter();

        double GetCircumference();
    }

    abstract public class Shape
    {
        private string _name { get; }
        private string _colour;

        public Shape(string name, string color)
        {
            this._name = name;
            this._colour = color;
        }
    }

    public abstract class Quadrilateral : Shape
    {
        private int _NumSides = 4;
        public Quadrilateral(string name, string color) : base(name, color)
        {
        }
        public int numSides()
        {
            return _NumSides;
        }

    }

    public class Square : Quadrilateral, IShapeProps
    {
        private double _sideLength;

        public Square(string name, string color, double sideLength) : base(name, color)
        {
            this._sideLength = sideLength;
        }
        public double GetArea()
        {
            return Math.Round(this._sideLength * this._sideLength, 2);
        }
        public double GetPerimeter()
        {
            return Math.Round( (4 * this._sideLength), 2);
        }

    }

    public class Rectangle : Quadrilateral, IShapeProps
    {
        private double _length;
        private double _width;
        public Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            this._length = length;
            this._width = width;
        }
        public double GetArea()
        {
            return Math.Round(this._length * this._width, 2);
        }

        public double GetPerimeter()
        {
            return Math.Round( ((2 * this._length) + (2 * this._width)), 2);
        }
    }

    public class Circle : Shape, ICircleProps
    {
        public const double PI = 3.142;
        private double _radius;
        public Circle(string name, string color, double radius) : base(name, color)
        {
            this._radius = radius;
        }
        public double GetArea()
        {
            return Math.Round( ((this._radius * this._radius) * PI), 2);
        }
        public double GetPerimeter()
        {
            return Math.Round( ((2 * this._radius) * PI), 2);
        }

        public double GetCircumference() 
        {
            return Math.Round( ((2 * this._radius) * PI), 2);
        }
    }
}