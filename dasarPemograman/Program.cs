using System;
/*
 using System;: Baris ini mengimport namespace System, 
yang berisi kelas-kelas dasar untuk pemrograman C#. 
Namespace ini digunakan untuk mendapatkan akses ke berbagai fitur dan fungsi dalam C#, 
seperti kelas String, kelas Console, dll.
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasarPemograman
/*
 Blok kode yang mengelompokkan kelas-kelas dan tipe-tipe lain ke dalam satu unit logis. 
Namespace digunakan untuk mengorganisir kode program dan mencegah terjadinya konflik 
nama antara kelas, variabel, dan metode yang berbeda.
 */
{
    internal class Program
    /*
     Blok kode yang mendefinisikan kelas NamaKelas. 
    Kelas ini berisi variabel dan metode yang digunakan dalam program. 
     */
    {
        /*
         Metode utama yang dieksekusi saat program dijalankan. 
        Metode ini harus ada dalam setiap program C# dan memiliki tipe pengembalian void(). 
        Metode ini digunakan untuk memulai eksekusi program dan menentukan urutan instruksi yang akan dijalankan.
         */
        static void Main(string[] args)
        {
            // Blok kode yang berisi perintah-perintah untuk menjalankan program.
            //--------------------------------------------------
            //digunakan untuk mengatur judul dari jendela konsol.
            Console.Title = "Aplikasi Kalkulator";

            // int a = 10;
            // int b = 67;

            // digunakan untuk mencetak teks tanpa mengakhiri baris
            Console.Write("Masukan Angka pertama : ");
            int a = int.Parse(Console.ReadLine());
            /*bertujuan untuk membaca inputan pengguna pada jendela konsol dan 
                mengubahnya menjadi tipe data integer. 
            */


            Console.Write("Masukan Angka kedua : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
            Console.WriteLine("Hasil Pengurangan " + a + " / " + b + " = " + Pembagian(a, b));
        }


        /*
         1. statis: Kata kunci ini menunjukkan bahwa metode milik kelas dan bukan turunan tertentu dari kelas.
         2. Ini menentukan tipe kembalian dari metode.
         3. Penambahan: Ini adalah nama metodenya.
         4. (int a, int b): Ini adalah parameter yang diteruskan ke metode. 
            Dalam hal ini, dua nilai bilangan bulat bernama a dan b diteruskan ke metode.
         
         */

        // ini metode dididalam kelass (metode miliki kelas)
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
