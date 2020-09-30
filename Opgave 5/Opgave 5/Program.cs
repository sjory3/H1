using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] table = new byte[5, 5];
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[0, 3] = 4;
            table[0, 4] = 5;
            
            table[1, 0] = 6;
            table[1, 1] = 7;
            table[1, 2] = 8;
            table[1, 3] = 9;
            table[1, 4] = 10;

            table[2, 0] = 11;
            table[2, 1] = 12;
            table[2, 2] = 13;
            table[2, 3] = 14;
            table[2, 4] = 15;

            table[3, 0] = 16;
            table[3, 1] = 17;
            table[3, 2] = 18;
            table[3, 3] = 19;
            table[3, 4] = 20;

            table[4, 0] = 21;
            table[4, 1] = 22;
            table[4, 2] = 23;
            table[4, 3] = 24;
            table[4, 4] = 25;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("    "+table[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
