using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Product
    {
        //name price and quantity
        private string name;
        private byte price;
        private string quantity;
        //makging the name price and quantity acccesable
        public string Name { get => name; set => name = value; }
        public byte Price { get => price; set => price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        //construcktor for making new obj
        public Product(string name, byte price, string quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
