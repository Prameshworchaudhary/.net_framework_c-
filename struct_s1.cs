using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncc_lab_prameshwor
{

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    
    internal class struct_s1
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,4);
            Console.WriteLine($"Point p1: {p1}");
        }

    }
}
