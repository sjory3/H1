using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessBook
{
    class ListMaking
    {
        public static void List(List<string> nameList, List<string> emailList, List<string> kommentList)
        {
            //because of the way the list works, all the name email and komment will be in the same index,
            string userinput;
            //ask for name and adds it to the list
            Console.WriteLine("Please enter the name of the student: ");
            userinput = Console.ReadLine();
            nameList.Add(userinput);
            //ask for email and adds it to the lists
            Console.WriteLine("Please enter the email of the student: ");
            userinput = Console.ReadLine();
            emailList.Add(userinput);
            //ask for komment and adds it to the list
            Console.WriteLine("Please enter the komment of the student: ");
            userinput = Console.ReadLine();
            kommentList.Add(userinput);
        }

        public static void Remove(List<string> nameList,List<string> emailList,List<string> kommentList)
        {
            //ask for email or name to see what list to check after
            string userInput;
            Console.WriteLine("how would you like to find the student\n1) Name\n2) Email");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("please enter the students name: ");
                userInput = Console.ReadLine();
                //using an tmp to get the index for the search and then using that same index on the other 2 lists
                int tmp = nameList.IndexOf(userInput);
                nameList.RemoveAt(tmp);
                emailList.RemoveAt(tmp);
                kommentList.RemoveAt(tmp);

                Console.WriteLine("Student removed from list");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("please enter the students Email: ");
                userInput = Console.ReadLine();
                //using an tmp to get the index for the search and then using that same index on the other 2 lists
                int tmp = emailList.IndexOf(userInput);
                nameList.RemoveAt(tmp);
                emailList.RemoveAt(tmp);
                kommentList.RemoveAt(tmp);

                Console.WriteLine("Student removed from list");
            }
            else
            {
                Console.WriteLine("please try again");
            }
        }
    }
}
