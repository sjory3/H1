using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input A for the perimeter and area Calculation: ");
            Square square = new Square();
            square.A = int.Parse(Console.ReadLine());
            Console.WriteLine("the perimeter is: " + square.PerimeterCalc());
            Console.WriteLine("the area is: " + square.Area());

            Console.WriteLine("Please input A for the perimeter and area Calculation: ");
            Square square1 = new Square();
            square1.A = int.Parse(Console.ReadLine());
            Console.WriteLine("the perimeter is: " + square1.PerimeterCalc());
            Console.WriteLine("the area is: " + square1.Area());

            Console.ReadKey();

        }
    }
}
