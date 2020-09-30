using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Michael, er sej.";
            char[] test2 = test.ToArray();

            Console.WriteLine(test);
            for (int i = 0; i < test2.Length;)
            {
                char userinput = Console.ReadKey().KeyChar;
                if (userinput == test2[i])
                {
                    Console.WriteLine(" Correct");
                    i++;
                }
                else
                {
                    Console.WriteLine(" Wrong");
                }

            }
            Console.ReadKey();
        }
    }
}
