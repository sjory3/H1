using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Pay
    {
        public static int Insert()
        {
            //kepping track for the user money that is insertet
            int userMoney = 0;
            int userMoneyInput = 0;
            bool continuation = true;
            while (continuation == true)
            {
                Console.WriteLine("===========================================================\n\n" +
                                  "   Please insert money input 0 to stop inserting money\n\n" +
                                  "===========================================================");
                //taking the user money and adding it to the usermoney if the input is over 0
                userMoneyInput = int.Parse(Console.ReadLine());
                if (userMoneyInput > 0)
                {
                    userMoney = +userMoneyInput;

                }
                else
                {
                    continuation = false;
                    Console.Clear();
                    Console.WriteLine("===========================================\n\n" +
                                      "         You have insertet: " + userMoney + "\n\n" +
                                      "===========================================");
                }
            }
            return userMoney;
        }
        //pay out the money or change after a buy or cancel
        public static int PayOut(int userMoney)
        {
            Console.WriteLine("==============================================\n\n" +
                              "     You have gotten: " + userMoney + " as change\n\n" +
                              "==============================================");
            userMoney = 0;
            return userMoney;
        }
    }
}
