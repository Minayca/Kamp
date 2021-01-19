using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri "+musteri.Ad+" "+musteri.Soyad+" eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Ad + " " + musteri.Soyad + " silindi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri " + musteri.Ad + " " + musteri.Soyad);
            }
            
        }
    }
}
