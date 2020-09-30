using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Guest
    {
        private string name;
        private byte age;

        public string Name { get => name; set => name = value; }
        public byte Age { get => age; set => age = value; }

        public Guest(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }

    }
}
