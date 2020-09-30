using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuation = true;
            while (continuation == true)
            {
                Console.WriteLine("What Would you like to do?\n\n1) Add 2 numbers\n2) Use Pythagoras to calculate C\n3) Insert your name and age\n4) The number 1-10 in ascending order\n5) The numbers 1-10 in descending order\n6) Inser X\n7) An array with 9 elements\n8) A list with even numbers\n9) Play lotto\n10) Guess a number\n11) A Selfdefinde method\n12) Close the program");
                byte userChoice = byte.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Please insert number 1");
                        int tal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please insert nnumber 2");
                        int tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nThe sum of the 2 numbers is: " + Math.Add(tal1, tal2));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        //getting user input to calculat C
                        Console.WriteLine("Plese insert A");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Plese insert B");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("C is: " + Math.Pythagoras(a, b));
                        if (a > b)
                        {
                            Console.Write(", and A is bigger than B");
                        }
                        else
                        {
                            Console.Write(", and B is bigger than A");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("your name please");
                        String name = Console.ReadLine();

                        Console.WriteLine("Hello " + name + " and what is you age?");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine(name + Math.Age(age));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine();
                        byte[] tableAss = new byte[10];
                        Math.OrderAssending(tableAss);
                        for (byte i = 0; i < tableAss.Length; i++)
                        {
                            Console.WriteLine(tableAss[i]);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine();
                        byte[] tableDes = new byte[10];
                        Math.OrderDessending(tableDes);
                        for (byte i = 0; i < tableDes.Length; i++)
                        {
                            Console.WriteLine(tableDes[i]);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("Please input X : ");
                        int userInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("X + 32 - 297 is : " + Math.LoopCalculation(userInput));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        //making the array as a byte because the number never go over 255
                        byte[] array = new byte[10];
                        Console.WriteLine("After the array manipulation: " + Math.ArrayManipulation(array));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 10:

                        break;

                    case 11:

                        break;

                    case 12:
                        continuation = false;
                        Console.WriteLine("The program will now close");
                        Console.ReadKey();
                        break;


                }
            }
        }
    }
}
