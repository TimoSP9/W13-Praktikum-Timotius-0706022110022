using System;
using System.Linq;

namespace W13_Praktikum_Timotius_0706022110022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berapa data = ");
            int data = Convert.ToInt32(Console.ReadLine());
            int Data = 1;
            while (Data<=data)
            {
                Console.WriteLine($"Data ke- {Data ++}  ");
                Console.Write("NIM            :");
                int NIM = Convert.ToInt32(Console.ReadLine());
                Console.Write("NAMA           :");
                string nama = Console.ReadLine();
                Console.Write("JENIS KELAMIN  :");
                string gender = Console.ReadLine();
                Console.Write("TAHUN MASUK    :");
                int tahun = Convert.ToInt32(Console.ReadLine());
                Console.Write("PROGRAM STUDI  :");
                string studi = Console.ReadLine();
                Console.Write("KELAS          :");
                var kls = Console.ReadLine();
            }
            Program.ngulang();
        }

        private static void ngulang()
        { 
            Console.Write("TAMBAH DATA? (y/n)");
            string tambah = Console.ReadLine();
            string y = tambah;
            string n = tambah;
            if (tambah == y)
            {
                return;
            }
            else if (tambah == n)
            {
                
            }
            else
                Console.Write("ulangi");
        }
    }
}
