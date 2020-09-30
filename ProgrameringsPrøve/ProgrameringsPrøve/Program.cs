using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameringsPrøve
{
    class Program
    {
        static void Main(string[] args)
        {
            //making the game controller 
            GameController gm = new GameController();

            //making the fighters as objects
            gm.MakeFighters();
            //selcting the first and second fighter
            Fighter first = gm.FirstPlaceing();
            Fighter second = gm.SecondPlaceing();
            //uotputting their names 
            Console.WriteLine("---------------------------\n" +
                              "    The 2 fighters are\n" +
                              "----------------------------\n" + first.Name + " VS " + second.Name);
            //finding the winner i know i should do so that it would output how much damage they did each turn but i dident plan my time and ran out
            Fighter winner = gm.Winner(first, second);

            //outputting the winner
            Console.WriteLine("\n\n------------------------\n" +
                              "       The winner is\n" +
                              "----------------------------\n" +
                              winner.Name +
                              "\n----------------------------");
            
            Console.ReadKey();
            //Gui
        }
    }
}
