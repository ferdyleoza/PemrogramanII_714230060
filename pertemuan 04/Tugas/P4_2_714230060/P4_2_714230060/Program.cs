using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230060
{
    // Abstraction - Class abstrak MediaItem
    abstract class MediaItem
    {
        // Encapsulation - Field dan property
        public string Judul { get; private set; }
        public int TahunTerbit { get; private set; }

        // Constructor
        public MediaItem(string judul, int tahunTerbit)
        {
            Judul = judul;
            TahunTerbit = tahunTerbit;
        }

        // Abstract method untuk polymorphism
        public abstract string GetInfo();
    }

    // Inheritance - Kelas Buku mewarisi MediaItem
    class Buku : MediaItem
    {
        public string Penulis { get; private set; }
        public int JumlahHalaman { get; private set; }

        public Buku(string judul, int tahunTerbit, string penulis, int jumlahHalaman)
            : base(judul, tahunTerbit)
        {
            Penulis = penulis;
            JumlahHalaman = jumlahHalaman;
        }

        // Polymorphism - Implementasi method GetInfo
        public override string GetInfo()
        {
            return $"Buku: {Judul}, oleh {Penulis}, Tahun: {TahunTerbit}, Halaman: {JumlahHalaman}";
        }
    }

    // Inheritance - Kelas Majalah mewarisi MediaItem
    class Majalah : MediaItem
    {
        public string Edisi { get; private set; }
        public string FrekuensiTerbit { get; private set; }

        public Majalah(string judul, int tahunTerbit, string edisi, string frekuensiTerbit)
            : base(judul, tahunTerbit)
        {
            Edisi = edisi;
            FrekuensiTerbit = frekuensiTerbit;
        }

        // Polymorphism - Implementasi method GetInfo
        public override string GetInfo()
        {
            return $"Majalah: {Judul}, Edisi: {Edisi}, Tahun: {TahunTerbit}, Frekuensi: {FrekuensiTerbit}";
        }
    }

    // Inheritance - Kelas DVD mewarisi MediaItem
    class DVD : MediaItem
    {
        public int Durasi { get; private set; } // dalam menit
        public string Rating { get; private set; }

        public DVD(string judul, int tahunTerbit, int durasi, string rating)
            : base(judul, tahunTerbit)
        {
            Durasi = durasi;
            Rating = rating;
        }

        // Polymorphism - Implementasi method GetInfo
        public override string GetInfo()
        {
            return $"DVD: {Judul}, Durasi: {Durasi} menit, Tahun: {TahunTerbit}, Rating: {Rating}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Daftar item media
            List<MediaItem> koleksi = new List<MediaItem>
            {
                new Buku("Pemrograman C#", 2022, "John Doe", 350),
                new Majalah("Teknologi Hari Ini", 2023, "Edisi Februari", "Bulanan"),
                new DVD("Film Inspirasi", 2021, 120, "PG-13")
            };

            // Tampilkan informasi koleksi media menggunakan polymorphism
            foreach (var item in koleksi)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.ReadLine();
        }
    }
}
