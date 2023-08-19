using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_15
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public int No;
        public int Sinif;

        public Ogrenci(string ad, string soyad, int no, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Sinif = sinif;
        }

        public void BilgiyiYazdir()
        {
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Numara: " + No);
            Console.WriteLine("Sınıf: " + Sinif);
            Console.WriteLine("-----------------------------");
        }
    }
}