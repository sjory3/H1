using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameringsPrøve
{
    class KattenTiger : Fighter
    {
        //i dident get to utilize this atribute but it inherence alle the atributes from Fighters
        private int life;

        public int Life { get => life; set => life = value; }

        public KattenTiger(string name, int hP, int atkMin, int atkMax, int defMin, int defMax, int life) : base(name, hP, atkMin, atkMax, defMin, defMax)
        {
            this.life = life;
        }
    }
}
