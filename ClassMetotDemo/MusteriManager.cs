using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + "\n");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + "\n");
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            //Console.WriteLine("Musteriler: " + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriAdresi + " " + musteri.MusteriTel + " " + musteri.MusteriBakiyesi + "TL");
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.MusteriId);
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri Adresi: " + musteri.MusteriAdresi);
                Console.WriteLine("Müşteri Telefonu: " + musteri.MusteriTel);
                Console.WriteLine("Müşteri Bakiyesi: " + musteri.MusteriBakiyesi + " TL \n");
            }
        }
    }
}
