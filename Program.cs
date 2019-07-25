using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> ListCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.WriteLine();
                //Console.WriteLine("Pilih Menu Aplikasi\n\n1. Tambah Customer\n2. Hapus Customer\n3. Tampilkan Customer\n4. Keluar");
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32 (Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1.Tambah Customer");
            Console.WriteLine("2.Hapus Customer");
            Console.WriteLine("3.Tampilkan Customer");
            Console.WriteLine("4.Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Customer customer = new Customer();
            Console.WriteLine("Tambah Data Customer");
            Console.Write("Kode : "); customer.Kode = Console.ReadLine();
            Console.Write("Nama : "); customer.Nama = Console.ReadLine();
            Console.Write("Piutang : "); customer.Piutang = Console.ReadLine();

            ListCustomer.Add(customer);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Data Customer");
            Console.Write("Masukkan Kode : "); string search = Console.ReadLine();

            int index = 0;
            foreach(Customer customer in ListCustomer){
                if(customer.Kode == search)
                {
                    Console.WriteLine("Kode Ada dan Berhasil Dihapus");
                    break;
                }
                index++;
            }
            ListCustomer.RemoveAt(index);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer");
            Console.WriteLine(" ");
            Console.WriteLine("No\t\tKode\t\tNama\t\tPiutang ");

            int index = 0;
            foreach(Customer customer in ListCustomer)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", index+1 ,customer.Kode, customer.Nama, customer.Piutang);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
