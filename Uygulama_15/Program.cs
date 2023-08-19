using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxOgrenciSayisi = 200;
            Ogrenci[] ogrenciler = new Ogrenci[maxOgrenciSayisi];
            int ogrenciSayisi = 0;

            while (true)
            {
                Console.WriteLine("1. Öğrenci Ekle.");
                Console.WriteLine("2. Öğrenci Ara.");
                Console.WriteLine("3. Öğrenci Sil.");
                Console.WriteLine("4. Tüm Öğrencileri Listele.");
                Console.WriteLine("5. Çıkış.");
                Console.Write("Seçiminizi yapın (1-5) : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (secim == 1)
                {
                    if (ogrenciSayisi < maxOgrenciSayisi)
                    {
                        Console.Write("Öğrenci Adı : ");
                        string ad = Console.ReadLine();

                        Console.Write("Öğrenci Soyadı : ");
                        string soyad = Console.ReadLine();

                        Console.Write("Öğrenci Numarası : ");
                        int no = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Öğrenci Sınıfı : ");
                        int sinif = Convert.ToInt32(Console.ReadLine());

                        Ogrenci yeniOgrenci = new Ogrenci(ad, soyad, no, sinif);
                        ogrenciler[ogrenciSayisi] = yeniOgrenci;
                        ogrenciSayisi++;
                        Console.WriteLine("**********************************");
                        Console.WriteLine("Öğrenci başarıyla eklendi.");
                        Console.WriteLine("**********************************");


                    }
                    else
                    {
                        Console.WriteLine("**********************************");
                        Console.WriteLine("Maksimum öğrenci sayısına ulaşıldı.");
                        Console.WriteLine("**********************************");
                    }

                }
                else if (secim == 2)
                {
                    Console.Write("Aranacak Öğrenci Numarası : ");
                    int arananNo = Convert.ToInt32(Console.ReadLine());

                    bool bulundu = false;
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        if (ogrenci != null && ogrenci.No == arananNo)
                        {
                            ogrenci.BilgiyiYazdir();
                            bulundu = true;
                            break;
                        }
                    }

                    if (!bulundu)
                    {
                        Console.WriteLine("**********************************");
                        Console.WriteLine("Öğrenci bulunamadı.");
                        Console.WriteLine("**********************************");
                    }
                }
                else if (secim == 3)
                {
                    Console.Write("Silinecek Öğrenci Numarası : ");
                    int silinecekNo = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < ogrenciSayisi; i++)
                    {
                        if (ogrenciler[i] != null && ogrenciler[i].No == silinecekNo)
                        {
                            ogrenciler[i] = null;
                            Console.WriteLine("**********************************");
                            Console.WriteLine("Öğrenci silindi.");
                            Console.WriteLine("**********************************");

                            break;
                        }
                    }
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Tüm Öğrenciler:");
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        if (ogrenci != null)
                        {
                            ogrenci.BilgiyiYazdir();
                        }
                    }

                }
                else if (secim == 5)
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Programdan çıkılıyor...");
                    Console.WriteLine("**********************************");
                    break;
                }
                else
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    Console.WriteLine("**********************************");
                }
            }
        }
    }
}
