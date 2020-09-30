using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    //we want to (nedarve) form Produkt contructor
    class Drink : Produkt
    {
        //new values for the constructor
        private int ml;
        private int pant;
        //getting and setting
        public int Ml { get => ml; set => ml = value; }
        public int Pant { get => pant; set => pant = value; }
        //constructor with the (nedarvet) class properties form Produkt
        public Drink(string name, int price, int ml, int pant) : base(name, price)
        {
            this.ml = ml;
            this.pant = pant;
        }
        //emty constructor for the information obj
        public Drink()
        {

        }
    }
}
