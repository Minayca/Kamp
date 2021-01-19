using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();

            musteri1.Ad = "Beren";
            musteri1.Soyad = "Alyüz";

            musteri2.Ad = "Onur";
            musteri2.Soyad = "Alyüz";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
