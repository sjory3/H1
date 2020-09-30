using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dining_Philsophers
{
    class Fork
    {
        int id;
        public Fork(int id)
        {
            this.id = id;
        }
    }

    class Program
    {
        static Fork[] fork = new Fork[5];

        static void Main(string[] args)
        {
            Thread[] philsophers = new Thread[5];

            for (int i = 0; i < philsophers.Length; i++)
            {
                fork[i] = new Fork(i);

            }
        }
    }
}
