using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    //we want to (nedarve) from the Drink constructor
    class Soda : Drink
    {
        //new property
        private bool sugerfree;
        //getting and setting
        public bool Sugerfree { get => sugerfree; set => sugerfree = value; }
        //constructor where we (nedarv) from Drink
        public Soda(string name, int price, int ml, int pant, bool sugerfree) : base(name, price, ml, pant)
        {
            this.sugerfree = sugerfree;
        }
        //emty constructor for the information
        public Soda()
        {

        }
    }
}
