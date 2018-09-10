using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOChallengeWeek4
{
    public class Shape
    {
        string Colour { get; set; }

        public Shape(string colour)
        {
            Colour = colour;
        }

    }

    public class Quadrilateral : Shape
    {

        public virtual int Side1Length { get; set; }
        public virtual int Side2Length { get; set; }
        public virtual int Side3Length { get; set; }
        public virtual int Side4Length { get; set; }

        public int GetPerimeter()
        {
            return (Side1Length + Side2Length + Side3Length + Side4Length);
        }

        public Quadrilateral(string colour, int s1, int s2, int s3, int s4)
            : base(colour)
        {
            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Side4Length = s4;
        }
    }

    public class Square : Quadrilateral
    {

        public Square(string colour, int s1)
            : base(colour, s1, s1, s1, s1)
        {

        }

        public virtual int GetArea()
        {
            return Side1Length * Side1Length;
        }
    }

    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int s1, int s2)
            : base(colour, s1, s2, s1, s2)
        {

        }

        public virtual int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }

    public class LessThanOneException : Exception
    {
        public LessThanOneException() : base("Please enter a value greater than 1")
        {

        }
    }
}
