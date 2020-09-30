using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Add
    {
        public static int add()
        {
            Console.WriteLine("Please input number 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number 2: ");
            int tal2 = int.Parse(Console.ReadLine());

            int sum = tal1 + tal2;
            return(sum);
        }
    }
}
