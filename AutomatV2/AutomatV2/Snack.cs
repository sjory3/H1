using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    //sayign we want to (nedarv) from the Produkt class
    class Snack : Produkt
    {
        //new values for a obj
        private int g;
        private string type;
        //getting and setting
        public int G { get => g; set => g = value; }
        public string Type { get => type; set => type = value; }
        //constructor with the (nedarvet) constructor from Produkt
        public Snack(string name, int price, int g, string type) : base(name, price)
        {
            this.g = g;
            this.type = type;
        }
        //emty constructor for the information object
        public Snack()
        {

        }
    }
}
