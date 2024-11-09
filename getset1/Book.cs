using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getset1
{
    public class Book : Product
    {
        public string Genre {get; set;}
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
        }
    }
}