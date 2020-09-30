using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Libary
{
    class book
    {
        private string name;
        private string author;
        private byte pages;
        private string genre;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public byte Pages { get => pages; set => pages = value; }
        public string Genre { get => genre; set => genre = value; }

        public book(string name, string author, byte pages,string genre)
        {
            this.Name = name;
            this.Author = author;
            this.Pages = pages;
            this.genre = genre;
        }

        public book()
        {

        }
    }
}
