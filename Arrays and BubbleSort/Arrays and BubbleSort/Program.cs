using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrray with 100 elements and a new random
            int[] tal = new int[100];
            Random random = new Random();
            //putting random numbers in the index
            for (int i = 0; i < tal.Length; i++)
            {
                int randomNumber = random.Next(0, 1000);
                tal[i] = randomNumber;
                Console.WriteLine(tal[i]);
            }
            Console.ReadKey();
            Console.Clear();
            //bubble sorting
            for (int i = 0; i <= tal.Length; i++)
            {
                for (int j = 0; j < (tal.Length - 1)-i; j++)
                {
                    if (tal[j] > tal[j + 1])
                    {
                        //checking if the first number is bigger than the next if true change place
                        //need the temp to change places
                        int temp = tal[j + 1];
                        tal[j + 1] = tal[j];
                        tal[j] = temp;
                    }
                }
            }
            //reversing the sort and outputting it to the user
            Array.Reverse(tal);
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }
            Console.ReadKey();

        }
    }
}
