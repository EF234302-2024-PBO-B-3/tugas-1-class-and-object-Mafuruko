namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        // Properti publik
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public double Berat { get; set; } // Dalam kilogram

        // Konstruktor untuk menginisialisasi properti
        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        // Metode untuk menampilkan informasi sepeda
        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat} kg");
        }
    }
}
