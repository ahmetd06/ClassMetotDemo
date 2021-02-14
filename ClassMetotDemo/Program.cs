using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { Id = 1, Adi = "Hakkı", Soyadi = "Bulut" };
            Musteri musteri2 = new Musteri { Id = 2, Adi = "Haluk", Soyadi = "Levent" };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Getir(musteri1);
            musteriManager.Sil(musteri1);
        }
    }
}
