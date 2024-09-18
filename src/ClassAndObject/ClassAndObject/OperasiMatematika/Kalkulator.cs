namespace ClassAndObject.OperasiMatematika
{
    public class Kalkulator
    {
        // Metode untuk penjumlahan
        public double Tambah(double a, double b)
        {
            return a + b;
        }

        // Metode untuk pengurangan
        public double Kurang(double a, double b)
        {
            return a - b;
        }

        // Metode untuk perkalian
        public double Kali(double a, double b)
        {
            return a * b;
        }

        // Metode untuk pembagian
        public double Bagi(double a, double b)
        {
            // Pastikan tidak terjadi pembagian dengan nol
            
            return a / b;
        }
    }
}
