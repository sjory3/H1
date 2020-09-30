using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------------------------------------
            //                       THE START
            //------------------------------------------------------------------------------------------------------------------------
            //changing the title of the program to "Automat"
            Console.Title = "Automat";
            //making the Automat object so we can access the "logic" layer or our maneger class
            Automat auto = new Automat();
            //staring with filling the automat
            auto.restock();
            //-----------------------------------------------------------------------------------------------------------------------
            //                         THE INFORMATION GATHERING
            //-----------------------------------------------------------------------------------------------------------------------
            //storing infomatino about the diffrent object and taking the information from the logic layer (we dont have a DAL)
            //Havsalt information
            string havSaltName = auto.HavSaltName();
            int havSaltPrice = auto.HavSaltPrice();
            int havSaltGram = auto.HavSaltGram();
            string havSaltType = auto.HavSaltType();
            //Haribo information
            string hariboName = auto.HariboName();
            int hariboPrice = auto.HariboPrice();
            int hariboGram = auto.HariboGram();
            string hariboType = auto.HariboType();
            //cola information
            string colaName = auto.ColaName();
            int colaPrice = auto.ColaPrice();
            int colaMl = auto.ColaMl();
            int colaPant = auto.ColaPant();
            bool colaSugerFree = auto.ColaSugerFree();
            //tuborg information
            string tuborgName = auto.TuborgName();
            int tuborgPrice = auto.TuborgPrice();
            int tuborgMl = auto.TuborgMl();
            int tuborgPant = auto.TuborgPant();
            float tuborgVol = auto.TuborgVol();
            //apple Juice information
            string appleName = auto.AppleName();
            int applePrice = auto.ApplePrice();
            int appleMl = auto.AppleMl();
            int applePant = auto.ApplePant();
            string appleType = auto.AppleType();

            //-------------------------------------------------------------------------------------------------------------
            //                      THE GUI
            //-------------------------------------------------------------------------------------------------------------
            //making a bool we change to false when we want the program to stop
            bool continuation = true;
            while (continuation == true)
            {
                //starting with a menu
                Console.Write("=========================================\n" +
                              "                Automat                  \n" +
                              "             1) buy Snack                \n" +
                              "             2) buy Drink                \n" +
                              "             3) show stock               \n" +
                              "                4) Exit                  \n" +
                              "=========================================\n" +
                              "Choice: ");
                //getting user input to select
                string userChoice = Console.ReadLine();
                //using the user input
                switch (userChoice)
                {
                    //-------------------------------------------------------------------------
                    //                       THE SNACK MENU
                    //-------------------------------------------------------------------------
                    case "1":
                        //clearing the console for the next menu
                        Console.Clear();
                        //the next menu
                        Console.WriteLine("=========================================\n" +
                                          "    What Snack Would you like to buy?    \n" +
                                          "           1) Kim´s Havsalt chips        \n" +
                                          "           2) Hariibo                    \n" +
                                          "=========================================\n" +
                                          "Choice: ");
                        //getting and using userinput
                        userChoice = Console.ReadLine();

                        //-----------------------------------------
                        //      Kims HavSlat chips
                        //-----------------------------------------

                        if (userChoice == "1")
                        {
                            //clearing and writing the next menu
                            Console.Clear();
                            //using the \n for a new line and reffering back the the information we took at the start
                            Console.WriteLine("=========================================\n" +
                                              "            You have chosen:             \n" +
                                              "          Name: " + havSaltName + "      \n" +
                                              "          Price: " + havSaltPrice + "    \n" +
                                              "          Gram: " + havSaltGram + "      \n" +
                                              "          Type: " + havSaltType + "      \n" +
                                              "=========================================\n" +
                                              "     would you like to continue?         \n" +
                                              "               1) Yes                    \n" +
                                              "               2) No                     \n" +
                                              "=========================================\n" +
                                              "Choice: ");
                            //getting and using user input
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //using the information to not hardcode the price, name ect.
                                Console.Clear();
                                Console.WriteLine("=========================================\n  " +
                                                  "         please insert :" + havSaltPrice + "\n");
                                //making a local money and starting the Money() mothod
                                int money = Money();
                                //checking if the money inputtet is enoguh
                                if (money >= havSaltPrice)
                                {
                                    //taking the user money
                                    money = money - havSaltPrice;
                                    //deleting the obj from the array
                                    auto.DeleteHavSalt();
                                    //writing to the user saying they have brought the item and using the dynamic information
                                    Console.Clear();
                                    Console.WriteLine("you have brought the item you will get: " +
                                                       money + " back\nThere is: " + auto.HavSaltCount() +
                                                       " " + havSaltName + " left");
                                }
                                else
                                {
                                    //in case not enough money was insertet
                                    Console.WriteLine("you dident insert enough money, please try again");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                /*
                                this is the same as saing 2 to go back to the menu but anything works so there is no reason to make a
                                else if (userinupt == "2")
                                {
                                    nothing
                                }
                                */
                            }
                        }

                        //----------------------------------------
                        //         Haribo
                        //----------------------------------------

                        //the same as "HavSalt but with Haribo"
                        else if (userChoice == "2")
                        {
                            //clear and next menu
                            Console.Clear();
                            //using the dynamic information from earlier
                            Console.WriteLine("=========================================\n" +
                                              "            You have chosen:             \n" +
                                              "          Name: " + hariboName + "       \n" +
                                              "          Price: " + hariboPrice + "     \n" +
                                              "          Gram: " + hariboGram + "       \n" +
                                              "          Type: " + hariboType + "       \n" +
                                              "=========================================\n" +
                                              "     would you like to continue?         \n" +
                                              "               1) Yes                    \n" +
                                              "               2) No                     \n" +
                                              "=========================================\n" +
                                              "Choice: ");
                            // getting and using userinput
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //cleaing and next menu
                                Console.Clear();
                                Console.WriteLine("=========================================\n  " +
                                                  "         please insert :" + hariboPrice + "\n");
                                //the money motod and a local int
                                int money = Money();
                                //checking if its enogh
                                if (money >= hariboPrice)
                                {
                                    //updating the local money
                                    money = money - hariboPrice;
                                    //deleting the object after it has been brought
                                    auto.DeleteHaribo();
                                    //cleaing and displaying information to the user
                                    Console.Clear();
                                    Console.WriteLine("you have brought the item you will get: " +
                                                       money + " back\nThere is: " + auto.HariboCount() +
                                                       " " + hariboName + " left");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("you dident insert enough money, please try again");
                                }
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please try again");
                        }
                        break;
                        //--------------------------------------------------------------------------------------------
                        //             DRINK MENU
                        //-------------------------------------------------------------------------------------------
                    case "2":
                        //cleaing and next menu
                        Console.Clear();
                        Console.WriteLine("=========================================\n" +
                                          "    What Drink Would you like to buy?    \n" +
                                          "           1) Cola                       \n" +
                                          "           2) Tuborg                     \n" +
                                          "           3) Apple Juice                \n" +
                                          "=========================================\n" +
                                          "Choice: ");
                        //getting and using user input
                        userChoice = Console.ReadLine();
                        //----------------------------------------------
                        //     COLA
                        //--------------------------------------------
                        if (userChoice == "1")
                        {
                            //cleaing and next menu
                            Console.Clear();
                            Console.WriteLine("=========================================\n" +
                                              "            You have chosen:             \n" +
                                              "          Name: " + colaName + "         \n" +
                                              "          Price: " + colaPrice + "       \n" +
                                              "          Ml: " + colaMl + "             \n" +
                                              "          Pant: " + colaPant + "         \n" +
                                              "          SugerFree: " + colaSugerFree +"\n" +
                                              "=========================================\n" +
                                              "     would you like to continue?         \n" +
                                              "               1) Yes                    \n" +
                                              "               2) No                     \n" +
                                              "=========================================\n" +
                                              "Choice: ");
                            //getting and using user input
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //clearing and displaying information
                                Console.Clear();
                                Console.WriteLine("=========================================\n  " +
                                                  "         please insert :" + colaPrice + "\n");
                                //local money and Money metod 
                                int money = Money();
                                //checking if it is enough
                                if (money >= colaPrice)
                                {
                                    //updating money
                                    money = money - colaPrice;
                                    //deleting object
                                    auto.DeleteCola();
                                    //clearing and display information
                                    Console.Clear();
                                    Console.WriteLine("you have brought the item you will get: " +
                                                       money + " back\nThere is: " + auto.ColaCount() +
                                                       " " + colaName + " left");
                                }
                                else
                                {
                                    Console.WriteLine("you dident insert enough money, please try again");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                /*
                                this is the same as saing 2 to go back to the menu but anything works so there is no reason to make a
                                else if (userinupt == "2")
                                {
                                    nothing
                                }
                                */
                            }
                        }

                        //---------------------------------
                        //           TUBORG
                        //---------------------------------

                        else if (userChoice == "2")
                        {
                            //clearing and next menu
                            Console.Clear();
                            Console.WriteLine("=========================================\n" +
                                              "            You have chosen:             \n" +
                                              "          Name: " + tuborgName + "       \n" +
                                              "          Price: " + tuborgPrice + "     \n" +
                                              "          Ml: " + tuborgMl + "           \n" +
                                              "          Pant: " + tuborgPant + "       \n" +
                                              "          Vol(%): "+ tuborgVol + "       \n" +
                                              "=========================================\n" +
                                              "     would you like to continue?         \n" +
                                              "               1) Yes                    \n" +
                                              "               2) No                     \n" +
                                              "=========================================\n" +
                                              "Choice: ");
                            //getting and using user input
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //clearing and displaying information
                                Console.Clear();
                                Console.WriteLine("=========================================\n  " +
                                                  "         please insert :" + tuborgPrice + "\n");
                                //local money = Money motod
                                int money = Money();
                                //checking if it is enough
                                if (money >= tuborgPrice)
                                {
                                    //updating money
                                    money = money - tuborgPrice;
                                    //deleting object
                                    auto.DeleteTuborg();
                                    //clearing and displaying information
                                    Console.Clear();
                                    Console.WriteLine("you have brought the item you will get: " +
                                                       money + " back\nThere is: " + auto.TuborgCount() +
                                                       " " + tuborgName + " left");
                                }
                                else
                                {
                                    Console.WriteLine("you dident insert enough money, please try again");
                                }
                                Console.ReadKey();
                            }
                        }

                        //---------------------------------------
                        //        APPLE JUICE
                        //---------------------------------------

                        else if (userChoice == "3")
                        {
                            //clearing and next menu
                            Console.Clear();
                            Console.WriteLine("=========================================\n" +
                                              "            You have chosen:             \n" +
                                              "          Name: " + appleName + "        \n" +
                                              "          Price: " + applePrice + "      \n" +
                                              "          Ml: " + appleMl + "            \n" +
                                              "          Pant: " + applePant + "        \n" +
                                              "          Type: " + appleType + "        \n" +
                                              "=========================================\n" +
                                              "     would you like to continue?         \n" +
                                              "               1) Yes                    \n" +
                                              "               2) No                     \n" +
                                              "=========================================\n" +
                                              "Choice: ");
                            //getting and using user input
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //clearing and next menu
                                Console.Clear();
                                Console.WriteLine("=========================================\n  " +
                                                  "         please insert :" + applePrice + "\n");
                                //local money and calling the money mothod
                                int money = Money();
                                //checking if it is enough
                                if (money >= applePrice)
                                {
                                    //updating money
                                    money = money - applePrice;
                                    //deleting object
                                    auto.DeleteApple();
                                    //clearing and displaying information
                                    Console.Clear();
                                    Console.WriteLine("you have brought the item you will get: " +
                                                       money + " back\nThere is: " + auto.AppleCount() +
                                                       " " + appleName + " left");
                                }
                                else
                                {
                                    Console.WriteLine("you dident insert enough money, please try again");
                                }
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please try again");
                        }
                        break;

                    //-----------------------------------------------------------
                    //             DISPLAY INFORMATION
                    //-----------------------------------------------------------

                    case "3":
                        //clearing and displaying count menu
                        Console.Clear();
                        Console.WriteLine("The Automat contains:\n" +
                                          "     Cola: " + auto.ColaCount() + "\n" +
                                          "     Tuborg: " + auto.TuborgCount() + "\n" +
                                          "     Applejuice: " + auto.AppleCount() + "\n" +
                                          "     Kim´s Havsalt: " + auto.HavSaltCount() + "\n" +
                                          "     Haribo: " + auto.HariboCount());
                        Console.ReadKey();
                        break;

                    case "4":
                        //clearing and making sure the user would like to exit
                        Console.Clear();
                        Console.WriteLine("=========================================\n\n" +
                                          "   ARE YOU SURE YOU WOULD LIKE TO EXIT   \n" +
                                          "                1) YES                   \n" +
                                          "                2) NO                    \n" +
                                          "=========================================\n" +
                                          "Choice: ");
                        userChoice = Console.ReadLine();
                        if (userChoice == "1")
                        {
                            //stooping the while loop
                            continuation = false;
                        }
                        break;
                        //secret case for restocking the automat
                    case "5":
                        //restocking 
                        auto.restock();
                        //clearing and showing that the automat has been restocked
                        Console.Clear();
                        Console.WriteLine("The automat has been refilled, it now contains:\n" +
                                          "     Cola: " + auto.ColaCount() + "\n" +
                                          "     Tuborg: " + auto.TuborgCount() + "\n" +
                                          "     Applejuice: " + auto.AppleCount() + "\n" +
                                          "     Kim´s Havsalt: " + auto.HavSaltCount() + "\n" +
                                          "     Haribo: " + auto.HariboCount());
                        Console.ReadKey();
                        break;
                        //the default if the user input was not 1, 2, 3, 4, or 5
                    default:
                        Console.WriteLine("please choose one of the options (1, 2, 3, 4)");
                        break;
                }
                Console.Clear();
            }
        }

        //making the method Money that returns an int
        public static int Money()
        {
            //making a string called userinput to make the while loop run
            string userInput = "";
            //making a money that is going to be returned
            int money = 0;
            //temp money to add money and tempmoney
            int moneytemp = 0;
            //checking is the user is done 
            while (userInput != "done")
            {
                userInput = Console.ReadLine();
                //if the user typed a number, parsing it to an int in the tempmoney
                if (Int32.TryParse(userInput, out moneytemp))
                {
                    //updating the money with the tempmoney
                    money = money + moneytemp;
                    //displaying how much money has been insertet
                    Console.WriteLine("you have insertet: " + money + "\nwhen you are done inserting money type 'done'");
                }
                //if done returning the the GUI
                else if (userInput == "done")
                {

                }
                //if miss type
                else
                {
                    Console.WriteLine("please only insert a number or write 'done' when you are done");
                }
            }
            //returning the money
            return money;
        }
    }
}
