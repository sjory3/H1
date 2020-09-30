using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a queue and adding 5 prime nummbers
            Queue<int> primeNum = new Queue<int>();

            primeNum.Enqueue(2);
            primeNum.Enqueue(3);
            primeNum.Enqueue(5);
            primeNum.Enqueue(7);
            primeNum.Enqueue(11);

            //the easy way to get the sum
            int total = 0;
            total = primeNum.Sum();

            //the other way to get the sum but also removes all the prime numbers
            int totalW = 0;
            while(primeNum.Count > 0)
            {
                totalW += primeNum.Dequeue();
            }

            Console.WriteLine(total);
            Console.WriteLine(totalW);

            Console.ReadKey();
        }
    }
}
