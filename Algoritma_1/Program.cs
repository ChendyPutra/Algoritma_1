using System;

namespace Bublbe_Sort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 20 Elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan Elemen Array");
            Console.WriteLine("------------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void Display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen Array Yang Telah Tersusun ");
            Console.WriteLine("----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // pada pass i, bandingkan n-1 elemen pertamana dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])// jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //creating the object of the bubblesort class
            Program myList = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.Display();
            //exit
            Console.WriteLine("\n\n Tekan Tombol Apa Saja Untuk Keluar.");
        }
    }
}