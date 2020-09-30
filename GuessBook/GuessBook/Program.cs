using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //making 3 list for name, email and komment
            List<string> nameList = new List<string>();
            List<string> emailList = new List<string>();
            List<string> kommentList = new List<string>();
            //preset names and email and komment for bug testing
            nameList.Add("Emil");
            nameList.Add("Bo");

            emailList.Add("emil@email.com");
            emailList.Add("bo@email.com");

            kommentList.Add("good");
            kommentList.Add("bad");
            //username and password for login in to delete students
            string adminName = "Admin";
            string adminPass = "Admin";
            //the useradmin and password the user tries to login with
            string userAdmin;
            string userAdminPass;
            //the userinput used diffrent places in the program
            string userInput;
            //keeps the program going 
            bool continuation = true;
            while (continuation == true)
            {
                //the menu for the user
                Console.WriteLine("What would you like to do:\n" +
                    "1) Insert a new student\n" +
                    "2) Show all data in list\n" +
                    "3) Seach a Email in the list\n" +
                    "4) Delete a student from the list\n" +
                    "5) Close the program");
                //the user choice for the menu
                string userChoice = Console.ReadLine();
                //redirecting the user based on what they want
                switch (userChoice)
                {
                    case "1":
                        //redirecting the code to another metod and importing the name,email and komment list from main
                        ListMaking.List(nameList, emailList, kommentList);
                        Console.WriteLine("the student have been added");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        //  the first try at printing the name, email and list out bacause it was easier to start with but dident look good
                        //Console.Write(nameList[i] + "    " + emailList[i] + "    " + kommentList[i] + "\n");
                        
                        //  updatet the list printing to look good when i had the time and after i checked stack overflow
                        //  dont completly understand how but i figured some out after i testet it to match 3 list insted for only 2 
                        Console.WriteLine("{0,-20} {1,-20} {2,-20}\n", "Name", "Email", "Komment");
                        for (int ctr = 0; ctr < nameList.Count; ctr++)
                            Console.WriteLine("{0,-20} {1,-20} {2,-20:N1}", nameList[ctr], emailList[ctr], kommentList[ctr]);

                        //the original code i copyed and changed to match my program
                        //
                        //                  Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
                        //                  for (int ctr = 0; ctr < names.Length; ctr++)
                        //                       Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Please enter the Email you would like to search for");
                        userInput = Console.ReadLine();
                        //usering .contains the check if the userinput and if it is it will return true
                        if (emailList.Contains(userInput))
                        {
                            Console.WriteLine("Yes that email is on the list");
                        }
                        else
                        {
                            Console.WriteLine("No that Email is not on the list, would you like to add a student? with that Email\n1) YES\n2) NO");
                            userChoice = Console.ReadLine();
                            if (userChoice == "1")
                            {
                                //redirecting the code to the other metod again
                                ListMaking.List(nameList, emailList, kommentList);
                                Console.WriteLine("The student have been added");
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("To delete a student from the list you need to login as admin");
                        Console.WriteLine("Please enter the Username: ");
                        userAdmin = Console.ReadLine();
                        //checking if the useradmin input is the same as adminname before redirecting to password input os that if it fails 
                        //they know it is the username and not the password that was worng
                        if (userAdmin == adminName)
                        {
                            Console.WriteLine("Please enter the Password: ");
                            userAdminPass = Console.ReadLine();
                            //if the password is correct the get redirectet to another mothod that can remove students
                            if (userAdminPass == adminPass)
                            {
                                ListMaking.Remove(nameList, emailList, kommentList);
                            }
                            else
                            {
                                Console.WriteLine("Wrong Password");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong username");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        //stopping the program and ending the loop
                        continuation = false;
                        Console.WriteLine("The program will now close");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
