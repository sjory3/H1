using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FIFO
{
    class GUI
    {
        byte userInput;

        Queue<Guest> guestQueue = new Queue<Guest>();

        bool continuation = true;

        public void MainMenu()
        {
            while (continuation == true)
            {

                Console.Clear();
                Console.WriteLine("" +
                    "==========================================" +
                    "\n\n        H1 Queue Operations Menu\n\n" +
                    "==========================================\n\n" +
                    "1) Add guest\n" +
                    "2) Delete guest\n" +
                    "3) Show the number of guest\n" +
                    "4) Show min and max guest\n" +
                    "5) Find an guest\n" +
                    "6) Print all guest\n" +
                    "7) Exit");
                try
                {
                    userInput = byte.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            AddGuest();
                            break;
                        case 2:
                            DeleteGuest();
                            break;
                        case 3:
                            ShowGuests();
                            break;
                        case 4:
                            
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            continuation = false;
                            //starwars();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter numbers 1-7");
                    Console.ReadKey();
                }
            }
        }



        public void AddGuest()
        {
            Console.Clear();
            Console.WriteLine("" +
                "==========================================\n\n" +
                "                 Add Guest                \n\n" +
                "==========================================\n\n" +
                "Please enter the name of the new guest:");
            string newUserName = Console.ReadLine();
            Console.WriteLine("Please enter the age of the new guest");
            try
            {
                byte newUserAge = byte.Parse(Console.ReadLine());
                guestQueue.Enqueue(new Guest(newUserName, newUserAge));
                Console.WriteLine("The guest " + newUserName + " has  been added to the list");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again and enter a number");
                Console.ReadKey();
            }
        }

        public void DeleteGuest()
        {
            string delete = "-------------Deleting Guest---------------";
            if (guestQueue.Count > 0)
            {
                guestQueue.Dequeue();

                Console.Clear();
                Console.WriteLine("==========================================\n\n");
                for (int i = 0; i < delete.Length; i++)
                {
                    Console.Write(delete[i]);
                    Thread.Sleep(50);
                }

                Console.Clear();
                Console.WriteLine("" +
                    "==========================================\n\n\n" +
                    "--------------Guest Deletet---------------\n\n\n" +
                    "==========================================\n\n" +
                    "      -= Press anykey to continue= -");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("" +
                "==========================================\n\n\n" +
                "------------No Guest to Delete------------\n\n\n" +
                "==========================================\n\n" +
                "       -=Press anykey to continue=-");
                Console.ReadKey();
            }

        }

        public void ShowGuests()
        {
            Console.Clear();
            if (guestQueue.Count > 0)
            {
                byte tmp = 0;
                Console.WriteLine("" +
                "==========================================\n\n\n" +
                "------------Showing all Guests------------\n\n\n" +
                "==========================================\n\n");
                foreach (Guest g in guestQueue)
                {
                    tmp++;
                    Console.WriteLine(tmp+") "+g.Name);
                }
                Console.WriteLine("" +
                "\n      -= Press anykey to continue=-");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("" +
                "==========================================\n\n\n" +
                "-------------No Guest to Show-------------\n\n\n" +
                "==========================================\n\n" +
                "     -= Press anykey to continue= -");
                Console.ReadKey();
            }
        }

        public void starwars()
        {
            Console.Beep(440, 500); Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350); Console.Beep(523, 150);
            Console.Beep(440, 500); Console.Beep(349, 350);
            Console.Beep(523, 150); Console.Beep(440, 1000);
            Console.Beep(659, 500); Console.Beep(659, 500);
            Console.Beep(659, 500); Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500); Console.Beep(349, 350);
            Console.Beep(523, 150); Console.Beep(440, 1000);
            Console.Beep(880, 500); Console.Beep(440, 350);
            Console.Beep(440, 150); Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Console.Beep(740, 250);
            Thread.Sleep(250); // Delay 250 milliseconds !!!!
            Console.Beep(455, 250); Console.Beep(622, 500);
            Console.Beep(587, 250); Console.Beep(554, 250);
            Console.Beep(523, 125); Console.Beep(466, 125);
            Console.Beep(523, 250);
            Thread.Sleep(250); // Delay 250 milliseconds !!!!
            Console.Beep(349, 125); Console.Beep(415, 500);
            Console.Beep(349, 375); Console.Beep(440, 125);
            Console.Beep(523, 500); Console.Beep(440, 375);
            Console.Beep(523, 125); Console.Beep(659, 1000);
            Console.Beep(880, 500); Console.Beep(440, 350);
            Console.Beep(440, 150); Console.Beep(880, 500);
            Console.Beep(830, 250); Console.Beep(784, 250);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Console.Beep(740, 250);
            Thread.Sleep(250);
            Console.Beep(455, 250); Console.Beep(622, 500);
            Console.Beep(587, 250); Console.Beep(554, 250);
            Console.Beep(523, 125); Console.Beep(466, 125);
            Console.Beep(523, 250);
            Thread.Sleep(250);
            Console.Beep(349, 250); Console.Beep(415, 500);
            Console.Beep(349, 375); Console.Beep(523, 125);
            Console.Beep(440, 500); Console.Beep(349, 375);
            Console.Beep(261, 125); Console.Beep(440, 1000);
            Thread.Sleep(100);
        }
    }
}
