using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    //we want to (nedarve) from the Drink constructor
    class Juice : Drink
    {
        //new prooperty
        private string type;
        //getting and setting
        public string Type { get => type; set => type = value; }
        //constructor with the propertys from Drinks
        public Juice(string name, int price, int ml, int pant, string type) : base (name, price, ml, pant)
        {
            this.type = type;
        }
        //emty for the information
        public Juice()
        {

        }
    }
}
