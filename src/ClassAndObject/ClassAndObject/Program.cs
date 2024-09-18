using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            // Membuat objek dari kelas
            Buku buku1 = new Buku("Pemrograman C#", "John Doe", 2021);
            Mobil mobil1 = new Mobil("Toyota", "Avanza", 2020);
            Laptop laptop1 = new Laptop("Dell", "Intel Core i7", 16, 512);
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 14.5);

            double hasilTambah = kalkulator.Tambah(10, 5);
            double hasilKurang = kalkulator.Kurang(10, 5);
            double hasilKali = kalkulator.Kali(10, 5);
            double hasilBagi = kalkulator.Bagi(10, 5);

            // Memanggil metode TampilkanInfo untuk menampilkan informasi
            buku1.TampilkanInfo();
            mobil1.TampilkanSpesifikasi();
            laptop1.TampilkanSpesifikasi();
            sepeda1.TampilkanInformasi();
            Console.WriteLine($"Hasil Penjumlahan: {hasilTambah}");
            Console.WriteLine($"Hasil Pengurangan: {hasilKurang}");
            Console.WriteLine($"Hasil Perkalian: {hasilKali}");
            Console.WriteLine($"Hasil Pembagian: {hasilBagi}");
        }
    }
}
