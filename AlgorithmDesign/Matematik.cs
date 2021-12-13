using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Matematik
    {
        public static double UstAlma(double taban, double ust)
        {
            double temp = 1;
            for (int i = 0; i < ust; i++)
            {
                temp *= taban;
            }
            return temp;
        }
        public static int[] AsalCarpanlarBul(int sayi)
        {
            string carpanListesi = "";
            int sayac = 2;

            while(sayi > 1)
            {
                if(sayi % sayac == 0)
                {
                    sayi /= sayac;
                    carpanListesi += sayac.ToString() + ",";        // carpanListesi = 2,
                }
                else
                {
                    sayac++;
                }
            }
            carpanListesi = Functions.IfadeninBelirliUzunlugunaKadarAl(carpanListesi);
            string[] dizi = Functions.IfadeyiKarakterCikararakDiziyeCevir(carpanListesi);
            carpanListesi = Functions.ElemanTekrarlarınıKaldir(dizi);
            dizi = Functions.IfadeyiKarakterCikararakDiziyeCevir(carpanListesi);
            int[] asalCarpanlar = Functions.StringDiziyiIntDiziyeCevir(dizi);
            return asalCarpanlar;      
        }
        public static int AsalÇarpanToplami(int sayi)
        {
            int toplam = 0;
            int[] asalSayilar = AsalCarpanlarBul(sayi);
            for (int i = 0; i < asalSayilar.Length; i++)
            {
                toplam += asalSayilar[i];
            }
            return toplam;
        }
        public static int AsalCarpanCarpimi(int sayi)
        {
            int carpim = 1;
            int[] asalCarpanlar = AsalCarpanlarBul(sayi);
            for (int i = 0; i < asalCarpanlar.Length; i++)
            {
                carpim *= asalCarpanlar[i];
            }
            return carpim;
        }
        public static int EKOK(int sayi1, int sayi2)
        {
            int carpim = 1;
            while (sayi1 != 1 && sayi2 != 1)
            {
                int sayac = 2;
                for (int i = 1; i <= (sayi1>sayi2 ? sayi1 : sayi2); i++)
                {
                    if (sayi1 % sayac == 0 || sayi2 % sayac == 0)
                    {
                        carpim *= sayac;
                        if (sayi1 % sayac == 0)
                            sayi1 /= sayac; 

                        if (sayi2 % sayac == 0)
                            sayi2 /= sayac;
                    }
                    else
                        sayac++;
                }
            }
            return carpim;
        }
        public static int EBOB(int sayi1, int sayi2)
        {
            int carpim = 1;
            while (sayi1 != 1 && sayi2 != 1)
            {
                int sayac = 2;
                for (int i = 1; i <= (sayi1 > sayi2 ? sayi1 : sayi2); i++)
                {
                    if (sayi1 % sayac == 0 || sayi2 % sayac == 0)
                    {
                        if (sayi1 % sayac == 0 && sayi2 % sayac == 0)
                            carpim *= sayac;
                        if(sayi1 % sayac == 0)
                            sayi1 /= sayac;
                        if(sayi2 % sayac == 0)
                            sayi2 /= sayac;
                    }
                    else
                        sayac++;
                }
            }
            return carpim;
        }
        public static int Faktoriyel(int sayi)
        {
            if (sayi == 1 || sayi == 0)
                return 1;
            else
                return (sayi * Faktoriyel(sayi-1));
        }
        public static double AralikliFaktoriyel(int baslangicFakt, int bitisFakt)
        {
            double toplam = 0;
            for (int i = baslangicFakt; i <= bitisFakt; i++)
            {
                toplam += Faktoriyel(i);
            }
            return toplam / (bitisFakt - baslangicFakt + 1);
        }
        public static void IkilikSayidanOndalikSayiyaCeviririm(string ifade)
        {
            int toplam = 0;
            bool kontrol = true;
            
            //Kontrol bloğu ifade içinde 0-1 olmadığı durumda 
            for (int i = 0; i < ifade.Length; i++)
            {
                if (!(ifade[i] == '1' || ifade[i] == '0'))      //'1' ve '0' char değerlerinin string ifadeden başka bir char ifadesi var ise
                {
                    Functions.YazdirConsoleRenkliHata("Hatalı Giriş");
                    kontrol = false;
                    break;
                }
            }
            int[] dizi = Functions.StringIfadeyiIntDiziyeCevir(ifade);
            Functions.Yazdir(dizi);

            if (kontrol)
            {
                for (int i = 0; i < ifade.Length; i++)
                    toplam += (int)Math.Pow(2, ifade.Length - 1 - i) * dizi[i];
                Console.WriteLine("{0} sayısının 10luk tabanda karşılığı: {1}", ifade,toplam);
            }
        }
    }
}
