using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square
    {
        private int a;

        public int A { get => a; set => a = value; }


        public Square()
        {

        }
        public int PerimeterCalc()
        {
            int perimeter;
            perimeter = 4 * a;
            return perimeter;
        }
        public int Area()
        {
            int area;
            area = a * a;
            return area;
        }
    }
}
