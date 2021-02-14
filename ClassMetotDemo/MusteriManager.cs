using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void Getir(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri getirildi");
        }
    }
}
