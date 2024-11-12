// Book_714230060.cs
using System;

namespace P4_1_714230060
{
    public class Book_714230060 : Product_714230060
    {
        public Book_714230060(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine("Book Name: " + Name);
            Console.WriteLine("Book Price: " + Price);
        }
    }
}
