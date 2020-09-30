using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    //we want to (nedarve) from the Drink constructor
    class Alcohol : Drink
    {
        //new property
        private float vol;
        //getting and setting
        public float Vol { get => vol; set => vol = value; }

        //constructor where we (nedarv) from Drink
        public Alcohol(string name, int price, int ml, int pant, float vol) : base(name, price, ml, pant)
        {
            this.Vol = vol;
        }
        //emty constructor for the information
        public Alcohol()
        {

        }

    }
}
