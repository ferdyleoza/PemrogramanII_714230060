// Product_714230060.cs
using System;

namespace P4_1_714230060
{
    public abstract class Product_714230060
    {
        private string name;
        private double price;

        public Product_714230060(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract void Display();
    }
}
