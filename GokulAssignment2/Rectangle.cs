using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokulAssignment2
{
    public class Rectangle
    {
        private int length, width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public Rectangle(int length, int width)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            if (width < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }

            if (length == width)
            {
                throw new ArgumentException("This is a Square because the parameters provided have the same value");
            }

            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            if (length < 1) Console.WriteLine("The length of the rectangle cannot be changed to a value less than one");
            else this.length = length;

            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            if (width < 1) Console.WriteLine("The width of the rectangle cannot be changed to a value less than one");
            else this.width = width;

            return this.width;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (width + length);
            return perimeter;
        }

        public int GetArea()
        {
            int area = width * length;
            return area;
        }
    }
}
