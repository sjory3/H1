using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            book b0 = new book();
            book b1 = new book("Karius and Bactus", "Thorbjørn Egner", 49, "Adult");
            book b2 = new book("brother Lionheart", "Astrid Lindgren", 227, "Adult");
            book b3 = new book("Hansel and Gretel", "Brothers Grimm", 32, "Adult");
            book b4 = new book("Pipi Longstocking", "Astrid Lindgren", 160, "Adult");

            List<book> bookList = new List<book>();

            bookList.Add(b0);
            bookList.Add(b1);
            bookList.Add(b2);
            bookList.Add(b3);
            bookList.Add(b4);

            Stack<book> userBooks = new Stack<book>();

            int userInput;
            int userChoice;


            bool continuation = true;
            while (continuation == true)
            {

                Console.WriteLine("--------Welcome to the library--------\n" +
                    "1) To rent a book\n" +
                    "2) To deliver a book\n" +
                    "3) To see all books that are available\n" +
                    "4) To exit the application");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        byte i = 0;
                        Console.Clear();
                        Console.WriteLine("---------------------------What book would you like to rent-------------------------\n");

                        Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", "ID : " + "Name", "Author", "Pages", "Genre");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        foreach (book item in bookList)
                        {
                            Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", i + ")   " + item.Name, item.Author, item.Pages, item.Genre);
                            i++;
                        }
                        //Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", "2)   " + b2.Name, b2.Author, b2.Pages, b2.Genre);
                        //Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", "3)   " + b3.Name, b3.Author, b3.Pages, b3.Genre);
                        //Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", "4)   " + b4.Name, b4.Author, b4.Pages, b4.Genre);

                        userInput = int.Parse(Console.ReadLine());

                        userBooks.Push(bookList[userInput]);

                        bookList.RemoveAt(userInput);

                        Console.WriteLine("the book has been rentet");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Would you like to deliver a book?\n1) Yes 2) No");
                        userInput = int.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            bookList.Add(userBooks.Pop());
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("Press anykey to return");
                            
                        }
                        else
                        {
                            Console.WriteLine("Please try again");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-----------------------------Here are all avalible books---------------------------\n");

                        Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", "Name", "Author", "Pages", "Genre");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        foreach (book item in bookList)
                        {
                            Console.WriteLine("{0,-20} {1, 20} {2, 20} {3, 20}", item.Name, item.Author, item.Pages, item.Genre);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        continuation = false;
                        break;
                }
            }
        }
    }
}
