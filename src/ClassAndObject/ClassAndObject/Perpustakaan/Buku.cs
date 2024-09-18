namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        // Properti publik
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int TahunTerbit { get; set; }

        // Konstruktor untuk menginisialisasi properti
        public Buku(string judul, string penulis, int tahunTerbit)
        {
            Judul = judul;
            Penulis = penulis;
            TahunTerbit = tahunTerbit;
        }

        // Metode untuk menampilkan informasi buku
        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}
