namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        // Properti publik
        public string Merk { get; set; }
        public string Model { get; set; }
        public int TahunProduksi { get; set; }

        // Konstruktor untuk menginisialisasi properti
        public Mobil(string merk, string model, int tahunProduksi)
        {
            Merk = merk;
            Model = model;
            TahunProduksi = tahunProduksi;
        }

        // Metode untuk menampilkan spesifikasi mobil
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}
