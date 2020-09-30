using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Performance
{
    class Program
    {
        public static void Main()
        {
            //string[] test = new string[1000000];
            
            Random random = new Random();
            string test = "";
            for (int i = 1; i < 1000001; i++)
            {
                random.Next(0, 9999);

                test = test + "\n" + i.ToString() + ", " + random.ToString();
                //Console.WriteLine(test);
            }

            File.WriteAllText(@".\hello.txt", test);

            string content = File.ReadAllText(@".\hello.txt");
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
