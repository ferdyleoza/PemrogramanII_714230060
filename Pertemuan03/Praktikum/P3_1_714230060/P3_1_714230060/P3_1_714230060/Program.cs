﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714230060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n-------------");
                Console.Write("\nMasukan nama Mahasiswa: ");
                String nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai");

                int nilai = Convert.ToInt16(Console.ReadLine());

                string[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukan indeks yg ditampilkan :");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("indeks persentasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali (Y/T)");
            }
            while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("sangat baik");
                    break;
                case 'B':
                    Console.WriteLine("baik");
                    break;
                case 'C':
                    Console.WriteLine("CUKUP");
                    break;
                case 'D':
                    Console.WriteLine("BURUK");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}