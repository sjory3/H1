using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Math
    {
        public static int Add(int tal1, int tal2)
        {
            int sum = tal1 + tal2;
            return (sum);
        }

        public static double Pythagoras(double a, double b)
        {
            double c2 = (a * a) + (b * b);
            double c = System.Math.Sqrt(c2);
            return (c);
        }

        public static string Age(int age)
        {
            if (age < 3)
            {
                return (", you need a diaper");
            }
            else if (age >= 3 && age <= 15)
            {
                return (", you have no POWER HERE!!!");
            }
            else if (age > 15 && age < 18)
            {
                return (", u are alowed to get drunk");
            }
            else if (age >= 18)
            {
                return (", you may vote and drive a car if you have a licens");
            }
            else
            {
                return ("i dont realy know");
            }
        }

        public static Array OrderAssending(byte[] table)
        {
            for (byte i = 0; i < table.Length; i++)
            {
                table[i] = i;
            }
            Array.Sort(table);
            return (table);
        }
        public static Array OrderDessending(byte[] table)
        {
            for (byte i = 0; i < table.Length; i++)
            {
                table[i] = i;
            }
            Array.Sort(table);
            Array.Reverse(table);
            return (table);
        }

        public static int LoopCalculation(int X)
        {
            for (int i = 0; i < 32; i++)
            {
                X++;
            }
            for (int i = 0; i < 297; i++)
            {
                X--;
            }
            return X;
        }

        public static byte ArrayManipulation(byte[] array)
        {
            for (byte i = 1; i < array.Length; i++)
            {
                //filling the array with numbers from 1-9
                array[i] = i;
            }

            Console.WriteLine("index 5 before the manipulation: " + array[5]);
            //taking the index 5 and making it the double of index 4
            array[5] = Convert.ToByte(array[4] * 2);

            return (array[5]);
        }
    }
}
