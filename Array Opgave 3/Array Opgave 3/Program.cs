using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList boyNameList = new ArrayList();
            ArrayList girlNameList = new ArrayList();

            boyNameList.Add("William");
            boyNameList.Add("Oliver");
            boyNameList.Add("Noah");
            boyNameList.Add("Emil");
            boyNameList.Add("Victor");
            boyNameList.Add("Magnus");
            boyNameList.Add("Frederik");
            boyNameList.Add("Mikkel");
            boyNameList.Add("Lucas");
            boyNameList.Add("Alexander");
            boyNameList.Add("Oscar");
            boyNameList.Add("Mathias");
            boyNameList.Add("Sebastian");
            boyNameList.Add("Malthe");
            boyNameList.Add("Elias");
            boyNameList.Add("Christian");
            boyNameList.Add("Mads");
            boyNameList.Add("Gustav");
            boyNameList.Add("Villads");
            boyNameList.Add("Tobias");

            girlNameList.Add("Emma");
            girlNameList.Add("Ida");
            girlNameList.Add("Clara");
            girlNameList.Add("Laura");
            girlNameList.Add("Isabella");
            girlNameList.Add("Sofia");
            girlNameList.Add("Sofie");
            girlNameList.Add("Anna");
            girlNameList.Add("Mathilde");
            girlNameList.Add("Freja");
            girlNameList.Add("Caroline");
            girlNameList.Add("Lærke");
            girlNameList.Add("Maja");
            girlNameList.Add("Josefine");
            girlNameList.Add("Liva");//that is bs
            girlNameList.Add("Alberte");
            girlNameList.Add("Karla");
            girlNameList.Add("Victoria");
            girlNameList.Add("Olivia");
            girlNameList.Add("Alam");


            //a bool to stop the while loop if wantet
            bool stop = true;

            Console.WriteLine("Helle we have the 20 top used boy nad girl names \n");

            while (stop == true)

            {
                Console.WriteLine("1) To check if a name is on the boi list\n2) To check if a name is on the gril list\n3) To add a name to the boy list\n4) To add a name to the girl list\n5) To remove a name from the boy list\n6) To remove a name from the girl list\n7) To sort the boy list\n8) To sort the girl list\n9) To stop the program");

                //making the user input to a byte (no fail safe if a number over 255 or a letter is typed)

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\nPlease enter the name you want to check");

                    string userInput = Console.ReadLine();

                    if (boyNameList.Contains(userInput) == true)
                    {
                        Console.WriteLine("yes, the name " + userInput + " is on the list\n");
                    }
                    else
                    {
                        Console.WriteLine("the name " + userInput + " is not on the list\n");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\nPlease enter the name you want to check");

                    string userInput = Console.ReadLine();

                    if (girlNameList.Contains(userInput) == true)
                    {
                        Console.WriteLine("yes, the name " + userInput + " is on the list\n");
                    }
                    else
                    {
                        Console.WriteLine("the name " + userInput + " is not on the list\n");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("\nPlease enter the name you want to add");

                    string userInput = Console.ReadLine();

                    if (boyNameList.Contains(userInput) == true)
                    {
                        Console.WriteLine("The name " + userInput + " is already on the list\n");
                    }
                    else
                    {
                        boyNameList.Add(userInput);
                        Console.WriteLine("The name " + userInput + " have been added to the list\nHere are the updatet list\n");
                        for (int i = 0; i < boyNameList.Count; i++)
                        {
                            //writing all the names after sorting and making a new line
                            Console.WriteLine(boyNameList[i]);
                        }
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nPlease enter the name you want to add");

                    string userInput = Console.ReadLine();

                    if (girlNameList.Contains(userInput) == true)
                    {
                        Console.WriteLine("The name " + userInput + " is already on the list\n");
                    }
                    else
                    {
                        girlNameList.Add(userInput);
                        Console.WriteLine("The name " + userInput + " have been added to the list\nHere are the updatet list\n");
                        for (int i = 0; i < girlNameList.Count; i++)
                        {
                            //writing all the names after sorting and making a new line
                            Console.WriteLine(girlNameList[i]);
                        }
                    }
                }
                else if (choice == "5")
                {
                    Console.WriteLine("\nPlease enter the name you want to remove");

                    string userInput = Console.ReadLine();

                    if (boyNameList.Contains(userInput) == true)
                    {
                        boyNameList.Remove(userInput);
                        Console.WriteLine("The name " + userInput + " has been removed\nHere is the updatet list\n");

                        for (int i = 0; i < boyNameList.Count; i++)
                        {
                            //writing all the names and making a new line
                            Console.WriteLine(boyNameList[i]);
                        }
                        //Console.WriteLine("The name " + userInput + " is already on the list\n");
                    }
                    else
                    {
                        Console.WriteLine("The name " + userInput + " is not on the list\nWould you like to add it (yes)/(no)\n");
                        string userChoice = Console.ReadLine();
                        if (userChoice == "yes")
                        {
                            boyNameList.Add(userInput);
                            Console.WriteLine("The name " + userInput + " have been added\nHere is the updatet list");
                            for (int i = 0; i < boyNameList.Count; i++)
                            {
                                //writing all the names and making a new line
                                Console.WriteLine(boyNameList[i]);
                            }
                        }
                    }
                }
                else if (choice == "6")
                {
                    Console.WriteLine("\nPlease enter the name you want to remove");

                    string userInput = Console.ReadLine();

                    if (girlNameList.Contains(userInput) == true)
                    {
                        girlNameList.Remove(userInput);
                        Console.WriteLine("The name " + userInput + " has been removed\nHere is the updatet list\n");

                        for (int i = 0; i < girlNameList.Count; i++)
                        {
                            //writing all the names and making a new line
                            Console.WriteLine(girlNameList[i]);
                        }
                        //Console.WriteLine("The name " + userInput + " is already on the list\n");
                    }
                    else
                    {
                        Console.WriteLine("The name " + userInput + " is not on the list\nWould you like to add it (yes)/(no)\n");
                        string userChoice = Console.ReadLine();
                        if (userChoice == "yes")
                        {
                            girlNameList.Add(userInput);
                            Console.WriteLine("The name " + userInput + " have been added\nHere is the updatet list");
                            for (int i = 0; i < girlNameList.Count; i++)
                            {
                                //writing all the names and making a new line
                                Console.WriteLine(girlNameList[i]);
                            }
                        }
                    }
                }

                else if (choice == "7")
                {
                    //sorting the array boysnamelist in alphabetical order
                    boyNameList.Sort();
                    for (int i = 0; i <boyNameList.Count; i++)
                    {
                        //writing all the names after sorting and making a new line
                        Console.WriteLine(boyNameList[i]);
                    }
                }
                else if (choice == "8")
                {
                    //sorting the array girlNameList in alphabetical order
                    girlNameList.Sort();
                    for (int i = 0; i <girlNameList.Count; i++)
                    {
                        //writing all the names after sorting and making a new line
                        Console.WriteLine(girlNameList[i]);
                    }
                }
                else if (choice == "9")
                {
                    //stopping the program
                    stop = false;
                }
            }
        }
    }
}