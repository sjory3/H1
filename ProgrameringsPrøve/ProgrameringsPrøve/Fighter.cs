using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameringsPrøve
{
    class Fighter
    {
        //fighter class witch all fighter inherence from
        private string name;
        private int hP;
        private int atkMin;
        private int atkMax;
        private int defMin;
        private int defMax;

        public string Name { get => name; set => name = value; }
        public int HP { get => hP; set => hP = value; }
        public int AtkMin { get => atkMin; set => atkMin = value; }
        public int AtkMax { get => atkMax; set => atkMax = value; }
        public int DefMin { get => defMin; set => defMin = value; }
        public int DefMax { get => defMax; set => defMax = value; }

        public Fighter(string name, int hP, int atkMin, int atkMax, int defMin, int defMax)
        {
            this.name = name;
            this.hP = hP;
            this.atkMin = atkMin;
            this.atkMax = atkMax;
            this.defMin = defMin;
            this.defMax = defMax;
        }
    }
}
