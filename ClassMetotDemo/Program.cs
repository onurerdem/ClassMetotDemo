using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Onur";
            musteri1.MusteriSoyadi = "Erdem";
            musteri1.MusteriAdresi = "İstanbul";
            musteri1.MusteriTel = "1234";
            musteri1.MusteriBakiyesi = "10";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyadi = "Demiroğ";
            musteri2.MusteriAdresi = "İstanbul";
            musteri2.MusteriTel = "4321";
            musteri2.MusteriBakiyesi = "2000";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Mehmet";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.MusteriAdresi = "Ankara";
            musteri3.MusteriTel = "2341";
            musteri3.MusteriBakiyesi = "100";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAdi = "Ahmet";
            musteri4.MusteriSoyadi = "Öztürk";
            musteri4.MusteriAdresi = "Ankara";
            musteri4.MusteriTel = "3412";
            musteri4.MusteriBakiyesi = "200";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriListeleme(musteriler);
        }
    }
}
