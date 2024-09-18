namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        // Properti publik
        public string Merk { get; set; }
        public string Prosesor { get; set; }
        public int Ram { get; set; } // Dalam GB
        public int Penyimpanan { get; set; } // Dalam GB

        // Konstruktor untuk menginisialisasi properti
        public Laptop(string merk, string prosesor, int ram, int penyimpanan)
        {
            Merk = merk;
            Prosesor = prosesor;
            Ram = ram;
            Penyimpanan = penyimpanan;
        }

        // Metode untuk menampilkan spesifikasi laptop
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}
