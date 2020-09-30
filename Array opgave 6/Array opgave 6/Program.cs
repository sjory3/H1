using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] excel = new int[2, 1];

            int result1 = 0;
            int result2 = 0;
            

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Enter cell {0} row {1}", j + 1, i + 1);
                    excel[i, j] = Convert.ToInt32(Console.ReadLine());

                    result1 = excel[i, 0];
                    result2 = excel[j, 0];
                }
            }
            Console.WriteLine("The result is : "+result1 + result2);
            Console.ReadKey();
        }
    }
}
