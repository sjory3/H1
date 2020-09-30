using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    abstract class Produkt
    {
        //super class for (nevarving kender ikke ordet på engelsk)
        //protected so only the (nedarvlet) class can use it
        protected string name;
        protected int price;
        //getting and setting 
        public int Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        //constructor 
        public Produkt(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        //emty constuctor for the information obj
        public Produkt()
        {

        }
    }
}
