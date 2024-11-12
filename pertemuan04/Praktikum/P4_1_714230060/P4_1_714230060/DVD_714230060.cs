// DVD_714230060.cs
using System;

namespace P4_1_714230060
{
    public class DVD_714230060 : Product_714230060
    {
        private int duration; // Durasi dalam menit
        private string director; // Sutradara dari DVD

        // Constructor untuk DVD dengan nama, harga, durasi, dan sutradara
        public DVD_714230060(string name, double price, int duration, string director) : base(name, price)
        {
            this.duration = duration;
            this.director = director;
        }

        // Properti untuk mendapatkan dan menetapkan durasi DVD
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        // Properti untuk mendapatkan dan menetapkan sutradara DVD
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        // Override metode Display untuk menampilkan detail DVD
        public override void Display()
        {
            Console.WriteLine("DVD Title: " + Name);
            Console.WriteLine("DVD Price: " + Price);
            Console.WriteLine("Duration: " + Duration + " minutes");
            Console.WriteLine("Director: " + Director);
        }
    }
}
