using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //making Queues with the diffrent drinks
            Queue<Product> colaQueue = new Queue<Product>();
            Queue<Product> fantaQueue = new Queue<Product>();
            Queue<Product> spriteQueue = new Queue<Product>();
            Queue<Product> redbullQueue = new Queue<Product>();
            Queue<Product> monsterQueue = new Queue<Product>();

            //making the diffrent drinks
            Product cola = new Product("Cola", 25, "50cl");
            Product fanta = new Product("Fanta", 25, "50cl");
            Product sprite = new Product("Sprite", 25, "50cl");
            Product redbull = new Product("Redbull", 20, "25cl");
            Product monster = new Product("Monster", 30, "50cl");

            //Filling up the stacks and there for the vending machine with items to the limit (8)
            while (colaQueue.Count < 8)
            {
                colaQueue.Enqueue(cola);
                fantaQueue.Enqueue(fanta);
                spriteQueue.Enqueue(sprite);
                redbullQueue.Enqueue(redbull);
                monsterQueue.Enqueue(monster);
            }
            //make varibles to use in the coming code
            int money = 0;
            byte newPrice;
            //admin name and pass to easier to change than go down and find the place in the code
            string adminName = "Admin";
            string adminPass = "root";

            string userName;
            string userPass;
            //continue the program until the user want it to stop
            bool continuation = true;
            while (continuation == true)
            {
                //changing the color 
                Console.ForegroundColor = ConsoleColor.White;
                //starting menu to change between user and admin
                Console.WriteLine("==========================================\n\n" +
                                  "   Are you Customer or are you Admin\n" +
                                  "             1) Customer\n" +
                                  "             2) Admin\n" +
                                  "             3) Exit\n\n" +
                                  "==========================================");
                string userChoice = Console.ReadLine();


                if (userChoice == "1")
                {
                    //refrence to the pay class and starting Insert() method
                    int userMoney = Pay.Insert();

                    //drink menu displaying the quantity (grams or cl) and cost
                    Console.WriteLine("==========================================\n\n" +
                                      "           What Would you like?\n" +
                                      "                1) Cola, " + cola.Quantity + ", Cost: " + cola.Price +
                                      "                2) Fanta, " + fanta.Quantity + ", Cost: " + fanta.Price +
                                      "                3) Sprite, " + sprite.Quantity + ", Cost: " + sprite.Price +
                                      "                4) Redbull, " + redbull.Quantity + ", Cost: " + redbull.Price +
                                      "                5) Monster, " + monster.Quantity + ", Cost: " + monster.Price +
                                      "==========================================");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        //cases for the diffrent drinks
                        case "1":
                            if (userMoney >= cola.Price)
                            {
                                //making the user able to cancel the order if it was regrettet 
                                Console.WriteLine("are you sure you would like to bye a cola for: " + cola.Price + " you have: " + userMoney + "\n" +
                                    "1) Yes\n" +
                                    "2) No");
                                userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    //removing a cola obj from the cola queue
                                    colaQueue.Dequeue();
                                    //updating the usermoney 
                                    userMoney = userMoney - cola.Price;
                                    //outputting the new user money and the cola count of how many left
                                    Console.WriteLine("You now have: " + userMoney + " money left and there is: " + colaQueue.Count + " colas left");
                                    //reffrence to the pay class and launch payout with usermoney
                                    userMoney = Pay.PayOut(userMoney);
                                    //updateing the amount of money the vending machine have
                                    money += cola.Price;
                                }
                                else
                                {
                                    //giving all the money back to the user
                                    userMoney = Pay.PayOut(userMoney);
                                }
                            }
                            else
                            {
                                //decline the user if the user dident input the requred ammount of money
                                Console.WriteLine("You dont have enough money to buy this item");
                                //and giving the money back
                                userMoney = Pay.PayOut(userMoney);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        //same as case 1 but with fanta
                        case "2":
                            if (userMoney >= fanta.Price)
                            {
                                Console.WriteLine("are you sure you would like to bye a fanta for: " + fanta.Price + " you have: " + userMoney + "\n" +
                                    "1) Yes\n" +
                                    "2) No");
                                userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    fantaQueue.Dequeue();
                                    userMoney = userMoney - fanta.Price;
                                    Console.WriteLine("You now have: " + userMoney + " money left and there is: " + fantaQueue.Count + " fantas left");
                                    userMoney = Pay.PayOut(userMoney);
                                    money += fanta.Price;
                                }
                                else
                                {
                                    userMoney = Pay.PayOut(userMoney);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy this item");
                                userMoney = Pay.PayOut(userMoney);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        //same as case 1 but with Sprite
                        case "3":
                            if (userMoney >= sprite.Price)
                            {
                                Console.WriteLine("are you sure you would like to bye a sprite for: " + sprite.Price + " you have: " + userMoney + "\n" +
                                    "1) Yes\n" +
                                    "2) No");
                                userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    spriteQueue.Dequeue();
                                    userMoney = userMoney - sprite.Price;
                                    Console.WriteLine("You now have: " + userMoney + " money left and there is: " + spriteQueue.Count + " sprites left");
                                    userMoney = Pay.PayOut(userMoney);
                                    money += sprite.Price;
                                }
                                else
                                {
                                    userMoney = Pay.PayOut(userMoney);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy this item");
                                userMoney = Pay.PayOut(userMoney);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        //same as case 1 but with redbull
                        case "4":
                            if (userMoney >= redbull.Price)
                            {
                                Console.WriteLine("are you sure you would like to bye a redbull for: " + redbull.Price + " you have: " + userMoney + "\n" +
                                    "1) Yes\n" +
                                    "2) No");
                                userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    redbullQueue.Dequeue();
                                    userMoney = userMoney - redbull.Price;
                                    Console.WriteLine("You now have: " + userMoney + " money left and there is: " + redbullQueue.Count + " redbulls left");
                                    userMoney = Pay.PayOut(userMoney);
                                    money += redbull.Price;
                                }
                                else
                                {
                                    userMoney = Pay.PayOut(userMoney);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy this item");
                                userMoney = Pay.PayOut(userMoney);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        //same as case 1 but with monster
                        case "5":
                            if (userMoney >= monster.Price)
                            {
                                Console.WriteLine("are you sure you would like to bye a monster for: " + monster.Price + " you have: " + userMoney + "\n" +
                                    "1) Yes\n" +
                                    "2) No");
                                userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    monsterQueue.Dequeue();
                                    userMoney = userMoney - monster.Price;
                                    Console.WriteLine("You now have: " + userMoney + " money left and there is: " + monsterQueue.Count + " monsters left");
                                    userMoney = Pay.PayOut(userMoney);
                                    money += monster.Price;
                                }
                                else
                                {
                                    userMoney = Pay.PayOut(userMoney);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy this item");
                                userMoney = Pay.PayOut(userMoney);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                }

                else if (userChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================\n\n" +
                                      "Please enter the Admin Username: (Admin)\n\n" +
                                      "========================================");
                    //asking for admin name and checking with existing admin name if its match
                    userName = Console.ReadLine();
                    if (userName == adminName)
                    {
                        Console.Clear();
                        Console.WriteLine("=======================================\n\n" +
                                          "Please enter the Admin Password: (root)\n\n" +
                                          "=======================================");
                        userPass = Console.ReadLine();
                        if (userPass == adminPass)
                        {
                            //changing the console color to green if the admin username and pass was correct
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.WriteLine("=======================================\n\n" +
                                              "            Accese Grantet\n\n" +
                                              "=======================================");
                            Console.ReadKey();
                            Console.Clear();
                            //Admin menu
                            Console.WriteLine("=====================================================\n\n" +
                                              "   would you like to restock items or change price\n" +
                                              "                  1) Restock items\n" +
                                              "                  2) Change price\n" +
                                              "                  3) Pay collcted money out\n" +
                                              "                  4) Back\n\n" +
                                              "=====================================================");
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //restock menu
                                Console.WriteLine("============================================" +
                                                  "    What item would you like to restock?\n" +
                                                  "                  1) Cola\n" +
                                                  "                  2) Fanta\n" +
                                                  "                  3) Sprite\n" +
                                                  "                  4) Redbull\n" +
                                                  "                  5) Monster\n\n" +
                                                  "============================================");

                                userChoice = Console.ReadLine();

                                switch (userChoice)
                                {
                                    case "1":
                                        //filling the queue up with new obj until full
                                        while (colaQueue.Count < 8)
                                        {
                                            colaQueue.Enqueue(cola);
                                            //confirming the queue has been filled
                                            Console.WriteLine("=============================================\n\n" +
                                                              "       Cola has been restock to: " + colaQueue.Count + "\n\n" +
                                                              "=============================================");
                                        }
                                        break;
                                    case "2":
                                        //same as case 1
                                        while (fantaQueue.Count < 8)
                                        {
                                            fantaQueue.Enqueue(fanta);
                                            Console.WriteLine("=============================================\n\n" +
                                                              "       Fanta has been restock to: " + fantaQueue.Count + "\n\n" +
                                                              "=============================================");
                                        }
                                        break;
                                    case "3":
                                        //same as case 1
                                        while (spriteQueue.Count < 8)
                                        {
                                            spriteQueue.Enqueue(sprite);
                                            Console.WriteLine("=============================================\n\n" +
                                                              "       Sprite has been restock to: " + spriteQueue.Count + "\n\n" +
                                                              "=============================================");
                                        }
                                        break;
                                    case "4":
                                        //same as case 1
                                        while (redbullQueue.Count < 8)
                                        {
                                            redbullQueue.Enqueue(redbull);
                                            Console.WriteLine("=============================================\n\n" +
                                                              "       Redbull has been restock to: " + redbullQueue.Count + "\n\n" +
                                                              "=============================================");
                                        }
                                        break;
                                    case "5":
                                        //same as case 1
                                        while (monsterQueue.Count < 8)
                                        {
                                            monsterQueue.Enqueue(monster);
                                            Console.WriteLine("=============================================\n\n" +
                                                              "       Monster has been restock to: " + monsterQueue.Count + "\n\n" +
                                                              "=============================================");
                                        }
                                        break;
                                }

                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (userChoice == "2")
                            {
                                //price change menu
                                Console.WriteLine("================================================\n\n" +
                                                  "What item would you like to change the price on?\n" +
                                                  "                1) Cola\n" +
                                                  "                2) Fanta\n" +
                                                  "                3) Sprite\n" +
                                                  "                4) Redbull\n5)" +
                                                  "                5) Monster\n" +
                                                  "                6) Back\n\n" +
                                                  "================================================");
                                userChoice = Console.ReadLine();
                                //changing the price for selectet products
                                switch (userChoice)
                                {
                                    case "1":
                                        Console.WriteLine("What is the new price for Cola");
                                        newPrice = byte.Parse(Console.ReadLine());
                                        cola.Price = newPrice;
                                        Console.WriteLine("The price has been changed to: " + cola.Price);
                                        break;
                                    case "2":
                                        Console.WriteLine("What is the new price for Fanta");
                                        newPrice = byte.Parse(Console.ReadLine());
                                        fanta.Price = newPrice;
                                        Console.WriteLine("The price has been changed to: " + fanta.Price);
                                        break;
                                    case "3":
                                        Console.WriteLine("What is the new price for Sprite");
                                        newPrice = byte.Parse(Console.ReadLine());
                                        sprite.Price = newPrice;
                                        Console.WriteLine("The price has been changed to: " + sprite.Price);
                                        break;
                                    case "4":
                                        Console.WriteLine("What is the new price for Redbull");
                                        newPrice = byte.Parse(Console.ReadLine());
                                        redbull.Price = newPrice;
                                        Console.WriteLine("The price has been changed to: " + redbull.Price);
                                        break;
                                    case "5":
                                        Console.WriteLine("What is the new price for Monster");
                                        newPrice = byte.Parse(Console.ReadLine());
                                        monster.Price = newPrice;
                                        Console.WriteLine("The price has been changed to: " + monster.Price);
                                        break;
                                    case "6":
                                        //emty case to simply cancel the price change by skipping it
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (userChoice == "3")
                            {
                                Console.WriteLine("you will now recive the collectet money");
                                Console.ReadKey();
                                Console.WriteLine("you have recived the collectet money:  " + money);
                                Console.ReadKey();
                                //outputting the money and changing the vending machine money to 0
                                money = 0;
                                Console.WriteLine("there is now: " + money + " money left");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (userChoice == "4")
                            {
                                //going back to starting menu and clearing any text on the screen
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Please again");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fail please try again");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Fail please try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (userChoice == "3")
                {
                    //stopping the program
                    continuation = false;
                    Console.WriteLine("The program will now close");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
