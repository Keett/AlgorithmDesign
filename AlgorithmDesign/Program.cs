using ConsoleApp1.Banka;
using ConsoleApp1.Cizim;
using ConsoleApp1.Modelleme;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void SekilCiz(Sekil sekil) => sekil.Ciz();
        public static void IEnumeratorKullanimi(string ifade)
        {
            IEnumerator rator = ifade.GetEnumerator();
            while (rator.MoveNext())
            {
                char karakter = (char)rator.Current;
                Console.Write(karakter + ".");
            }
            Console.WriteLine("İkinci bir yöntem IEnumerator kullanmadan yapılan klasik yöntemdir. Yöntem aşağıdaki gibidir.");
            foreach (char karakter in ifade)
                Console.Write(karakter + ".");
        }
        internal class MyCollection : IEnumerable
        {
            int[] data = { 1, 2, 3 };

            public IEnumerator GetEnumerator()
            {
                foreach (int item in data)
                {
                    yield return item;
                }
            }
        }
        internal class MyGenericCollection : IEnumerable<int>
        {
            int[] data = { 1, 2, 3 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (int item in data)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        static void Main(string[] args)
        {
            /// <summary>
            /// Functions.DegiskenlerKod();
            /// Functions.BoxingUnboxingKod();
            /// Functions.SabitDegisken();
            /// Functions.VarDegisken();
            /// Functions.UygulamaElseIf();
            /// Console.WriteLine(Functions.Toplam(5,2));
            ///  
            /// int deger = Convert.ToInt32(Console.ReadLine());
            /// Console.WriteLine(Functions.AsalMi(deger) ? "Asal sayı ":"Asal sayı değil");
            /// Console.WriteLine(Functions.BasamakDegerToplami(deger));
            ///  
            /// Console.WriteLine("2-80 arası çift sayı toplamı = {0,5}\n2-48 arası çift sayı toplamı = {1,5} => \n50-80 arası çift sayı toplamı ise = {2,5}'dir",Functions.CiftSayiToplami(80), Functions.CiftSayiToplami(48),Functions.CiftSayiToplami(80) - Functions.CiftSayiToplami(48));
            /// Functions.DesenOLustur('&', 5);
            /// 
            /// Functions.ASCII_Karakter();
            /// Functions.ASCII_Karakter(128, 255, 10);
            /// 
            /// Console.Write("Taban değerini giriniz: ");
            /// double sayi1 = Convert.ToDouble(Console.ReadLine());
            /// Console.Write("Üst değerini giriniz: ");
            /// double sayi2 = Convert.ToDouble(Console.ReadLine());
            /// Console.WriteLine("{0} ^ {1} = {2}", sayi1, sayi2, Matematik.UstAlma(sayi1, sayi2));
            /// 
            /// Functions.Yazdir(Matematik.AsalCarpanlarBul(60));
            /// Console.WriteLine("{0} sayısının Asal çarpanlar toplamı: {1}\nAsal çarpanlar çarpimi:{2}", 60, Matematik.AsalÇarpanToplami(60), Matematik.AsalCarpanCarpimi(60));
            /// 
            /// Console.Write("İlk sayıyı giriniz: ");
            /// int sayi1 = Convert.ToInt32(Console.ReadLine());
            /// Console.Write("İkinci sayıyı giriniz: ");
            /// int sayi2 = Convert.ToInt32(Console.ReadLine());
            /// Console.WriteLine("EKOK({0},{1}) = {2}", sayi1, sayi2, Matematik.EKOK(sayi1, sayi2));
            /// Console.WriteLine("EBOB({0},{1}) = {2}", sayi1, sayi2, Matematik.EBOB(sayi1, sayi2));
            /// 
            /// Console.WriteLine(Matematik.Faktoriyel(3));
            /// Console.WriteLine(Matematik.AralikliFaktoriyel(2, 7));
            /// 
            /// Console.Write("2lik tabanda sayı giriniz: ");
            /// string ifade = Console.ReadLine();
            /// Matematik.IkilikSayidanOndalikSayiyaCeviririm(ifade);
            /// 
            /// Console.WriteLine(Functions.IfadeIcindekiSesliHarfSayisi("Kübra Elif"));
            /// 
            /// int[,] dizi = MatrisOlustur.AltUcgenOlustur(5);
            /// Matris.MatrisYazdir(dizi);
            /// Console.WriteLine("Alt Üçgen mi: ");
            /// Console.WriteLine(MatrisKontrol.AltUcgenMi(dizi));
            ///
            /// 
            /// </summary>
            /// 

            /// <summary>
            /// 
            /// try
            /// {
            /// string dosyaYolu = DosyaIslemleri.DinamikKonumAtama("Rakamlar.txt");
            /// string[] adListesi = new string[] { "hasan", "mert", "ayşe", "zeliha", "kayra", "neşe" };
            /// DosyaIslemleri.DosyayaListeYaz(dosyaYolu, adListesi);
            /// DosyaIslemleri.DosyadanDegerOkuKonsolaYaz(dosyaYolu);
            /// DosyaIslemleri.VarOlanDosyayaVeriEkleme(dosyaYolu);
            /// DosyaIslemleri.DosyaBilgisi(dosyaYolu);
            /// DosyaIslemleri.DosyaKopyala(DosyaIslemleri.DinamikKonumAtama("AdlarKopya.txt"), DosyaIslemleri.DinamikKonumAtama("Adlar.txt"));
            /// string dosya = DosyaIslemleri.DinamikKonumAtama("AdlarKopya.txt");
            /// DosyaIslemleri.DosyaSil(dosya);    
            /// }
            /// catch (Exception ex)
            /// {
            ///    Console.WriteLine(ex.Message);
            ///    throw;
            /// }
            /// 
            /// </summary>

            /// <summary>
            /// 
            /// partial class ile bir sınıfı ikiye bölme işlemi 
            /// PartialClassOrnegi p = new PartialClassOrnegi();
            /// PartialClassOrnegi p2 = new PartialClassOrnegi("veri");
            /// 
            /// </summary>
            /// 

            /// <summary>
            /// 
            /// Arac arac = new Arac("Wolsvogen", "Polo", "Beyaz", 2020)
            /// {
            ///     Motor = Motor.Dizel.ToString(),
            ///     Hacim = 1.6
            /// };
            /// arac.ToString();
            /// arac.Temizle();
            /// 
            /// ******************************************************************************
            /// 
            /// List<Arac> aracFilosu = new List<Arac>();
            /// aracFilosu.Add(new Arac
            /// {
            ///     Marka = "Skoda",
            ///     Model = "Octavia",
            ///     Renk = Renk.Kirmizi.ToString(),
            ///     Yil = 2018,
            ///     Motor = Motor.Benzin.ToString(),
            ///     Hacim = 1.8
            /// });
            /// aracFilosu.Add(new Arac
            /// {
            ///     Marka = "Opel",
            ///     Model = "Corsa",
            ///     Renk = Renk.Mavi.ToString(),
            ///     Yil = 2015,
            ///     Motor = Motor.Dizel.ToString(),
            ///     Hacim = 1.6
            /// });
            /// foreach (Arac item in aracFilosu)
            ///     item.ToString();
            ///     
            /// *****************************************************************************
            /// 
            /// var k = new Dikdortgen();
            /// k.Pozisyon.X = 81;
            /// k.Pozisyon.Y = 12;
            /// k.Boyut.Genişlik = 100;
            /// k.Boyut.Yukseklik = 53;
            /// SekilCiz(k);
            /// k.Tasi(new Pozisyon { X = 10, Y = 40 });
            /// 
            /// 
            /// Sekil s1 = new Dikdortgen(50,50,100,100);
            /// SekilCiz(s1);
            /// 
            /// IBankaHesap mevduatHesabi = new MevduatHesabi();
            /// ITransfer aktifHesap = new AktifHesap();
            /// aktifHesap.ParaYatir(250);
            /// aktifHesap.TransperYap(mevduatHesabi, 200);
            /// Console.WriteLine(mevduatHesabi.ToString());
            /// Console.WriteLine(aktifHesap.ToString());
            /// 
            /// 
            /// 
            /// </summary>

            ///<summary>
            ///
            /// Array dizi = Array.CreateInstance(typeof(Int32), 3);
            /// dizi.SetValue(54, 0);
            /// dizi.SetValue(34, 1);
            /// dizi.SetValue(12, 2);
            /// for (int i = 0; i < dizi.Length; i++)
            ///     Console.WriteLine(dizi.GetValue(i));
            /// 
            ///</summary>

            int[] dizi = { 0, 1, 2, 3, 4, 5 };
            List<int> liste = new List<int>();
            string[] isimler = { "Ali", "Ahmet", "Derya" };
            double sayisalDeger = 56331636464;
            for (int i = 5; i < 10; i++)
            {
                liste.Add(i);
            }

            ProcessItems<int>(dizi);
            ProcessItems<int>(liste);
            ProcessItems<string>(isimler);
        }

        private static void ProcessItems<T>(IList koleksiyon)
        {
            Console.WriteLine("Is readonly, returns {0} for this collection - Eğer sadece okunabilir ise bu kolaksiyondan {0} geri döner", koleksiyon.IsReadOnly);
            foreach (T item in koleksiyon)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
