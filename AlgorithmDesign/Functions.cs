using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Functions
    {
        /// <summary>
        /// System sınıfının altındaki Int16, Int32, Byte türlerinin min ve max değerlerini konsola yazdıran fonksiyon
        /// </summary>
        public static void DegiskenlerKod()
        {
            Console.WriteLine("Hello World! I am Ket and I am a wonderwoman");
            int maks16, mins16, maks32, mins32;
            maks16 = System.Int16.MaxValue;
            mins16 = System.Int16.MinValue;
            maks32 = System.Int32.MaxValue;
            mins32 = System.Int32.MinValue;
            Console.WriteLine("Intt16 -> Min:{0}, Int16 -> Maks:{1}\n Int32-> Min:{2}, Int32->Max:{3}", mins16, maks16, mins32, maks32);
            byte minByte, maxByte;
            minByte = System.Byte.MinValue;
            maxByte = System.Byte.MaxValue;
            Console.WriteLine("Min Byte: {0}, Max Byte: {1}", minByte, maxByte);
        }

        /// <summary>
        /// Değer ve referans türlü değişken örneklemesi
        /// int -> obj (boxing)
        /// obj -> int (unboxing)
        /// </summary>
        public static void BoxingUnboxingKod()
        {
            //kutulama - boxing
            int i = 81;     //değer türlü değişken
            object obj = i;     //referans türlü değişken 
            //object, int i kapsar 

            //kutudan çıkarma - unboxing
            i *= 2;
            i = (int)obj; // cast işlemi -- (int) yazma


            // int -> Object(boxing)
            // Object -> int (unboxing)
        }
        
        /// <summary>
        /// const ve dynamic değişken türü kullanımları
        /// </summary>
        public static void SabitDegisken()
        {
            //static ifade const ile birlikte kullanılmaz :  static const c = 81; yapılamaz.
            const int c = 81_000_000;   //digit seperator büyüük sayıları basamaklarına ayırarak yazma 
                                        //sabitlere oluşturulduğu yerde değeri verilmelidir.
                                        //const int c;
                                        //c=81; ataması yapılamıyor 
                                        //readonly kullanılmalı

            //object sayi = 10;
            //sayi = sayi + 20;     yanlış kullanım     boxing/unboxing yapılmalı

            dynamic sayi = 10;
            sayi += 20;
            Console.WriteLine(sayi);

        }

        /// <summary>
        /// 'a' karakteri ile başlayan listedeki elemanı foreach ile tarayan fonksiyon
        /// </summary>
        public static void VarDegisken()
        {
            string[] meyveler = { "elma", "armut", "muz", "ayva" };
            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;
            foreach (string item in meyve)
            {
                Console.Write(item + " - ");
            }
        }
        
        /// <summary>
        /// Girilen karakterin büyük harf, küçük harf ve rakam olup olmadığının kontrolü
        /// </summary>
        public static void UygulamaElseIf()
        {
            Console.Write("Bir karakter giriniz:  ");
            char ch = (char)Console.Read();
            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter büyüktür.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter küçüktür.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen rakamdır");
            }
            else
            {
                Console.WriteLine("Karakter tanımlanamadı. Karakter alfanumerik değildir");
            }
        }
        
        /// <summary>
        /// 3 tane bölüm işaretine basılarak otomatik oluşturuldu
        /// Fonk. ne iş yapıyor yazılacak bu bölüme
        /// </summary>
        /// <param name="x">Birinci toplanacak sayı</param>
        /// <param name="y">İkinci Toplanacak sayı</param>
        /// <returns>Geri dönüş değeri</returns>
        public static int Toplam(int x, int y)
        {
            int z = x + y;
            return z;

            //Fonk static tanımlanmasaydı; Class1 c = new Class1(); Nesne olşuturulması gerekiyordu kullanılması için 
            //Static tanımlama referans veya nesne gerekmeksizin değişkenlerin veya fonksiyonların kullanılmasını sağlar..
        }
        
        /// <summary>
        /// girilen sayının asal olup olmadığının kontrolü 
        /// </summary>
        /// <param name="sayi">parametre olarak verilen int sayı</param>
        /// <returns>bool değer</returns>
        public static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                Console.WriteLine("En küçük asal sayı 1e eşit veya 1den küçük değildir.");
                return false;
            }
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }
        
        /// <summary>
        /// girilen sayının basamak değerlerinin toplamını bulan fonksiyon
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns>int türünde basamak değer toplamı </returns>
        public static int BasamakDegerToplami(int sayi)
        {
            int toplam = 0, kalan = 0;
            while (sayi > 0)
            {
                kalan = sayi % 10;
                toplam += kalan;
                sayi /= 10;
            }
            return toplam;
        }
        
        /// <summary>
        /// Paremetre olarak verilen sayı 'ya kadar olan çift sayıların toplamı
        /// </summary>
        /// <param name="sayi">[0-sayi]</param>
        /// <returns>int toplam değeri </returns>
        public static int CiftSayiToplami(int sayi)
        {
            int n = sayi / 2;
            return n * (n + 1);
        }
        
        /// <summary>
        /// Paremetre değerine bağlı olarak desen oluşturan fonksiyon
        /// </summary>
        /// <param name="c">Desen oluşumunda etkili karakter</param>
        /// <param name="tekrar">Desen boyutu</param>
        public static void DesenOLustur(char c, int tekrar)
        {
            for (int i = 1; i <= tekrar; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i));
            }
        }

        /// <summary>
        /// Varsayılan olarak değerler atandığı için foksiyon çağırıldığında 
        /// parametreleri eksik veya hiç girilmese de hata alınmaz varsayılan değerler kullanılır
        /// satir sayısı kadar karakter bas sonra alt satıra geç
        /// </summary>
        /// <param name="baslangicIndisi">Karakterin ascii tablosundaki başlangıç değeri</param>
        /// <param name="bitisIndisi">Karakterin ascii tablosundaki bitiş değeri</param>
        /// <param name="satirSayisi">Gösteriminde alt satıra geçiş değeri</param>
        public static void ASCII_Karakter(int baslangicIndisi = 65, int bitisIndisi = 90, int satirSayisi = 5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            {
                if (i % satirSayisi == 0)   
                    Console.WriteLine();
                Console.Write("{0,10}", (char)i);
            }
        }
        
        /// <summary>
        /// Parametre olarak verilwn ifadenin 0. indisinden uzunluğunun 1 eksiğine kadar olan bölümün alınması
        /// En sondaki karakterin saf dışı bırakılması
        /// </summary>
        /// <param name="ifade"></param>
        /// <returns>string ifade</returns>
        public static string IfadeninBelirliUzunlugunaKadarAl(string ifade)
        {
            return ifade.Substring(0, ifade.Length - 1);
        }
        
        /// <summary>
        /// string türünde tek boyutlu bir dizi alınıp dizi üzerinde gezinerek eleman tekrarlarının kaldırılıp strüng türünde bir ifade geri döndürür
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>string türünde ifade</returns>
        public static string ElemanTekrarlarınıKaldir(string[] dizi)
        {
            string temp = dizi[0];
            string yeniIfade = temp;

            for (int i = 1; i < dizi.Length; i++)
            {
                if (!(temp == dizi[i]))
                {
                    yeniIfade = yeniIfade + "," + dizi[i];
                    temp = dizi[i];
                }
            }
            return yeniIfade;
        }
        
        /// <summary>
        /// string değişken türünde tek boyutlu diziyi int türünde tek boyutlu diziye çevirme 
        /// </summary>
        /// <param name="dizi">string türünde tek boyutlu dizi</param>
        /// <returns>int değişken türünde tek boyutlu dizi</returns>
        public static int[] StringDiziyiIntDiziyeCevir(string[] dizi)
        {
            int[] yeniDizi = new int[dizi.Length];
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                yeniDizi[i] = Convert.ToInt32(dizi[i]);
            }
            return yeniDizi;
        }

        /// <summary>
        /// Paremetre olarak alından string bir ifadenin Int değişken türünde tek boyutlu bir diziye dönüşümü
        /// char karşılığı '0' değeri = 48 dir 
        /// '1' değerinin char karşılığı 49 dur
        /// buradan anlaşılacağı üzere '1' - '0' yaptığımızda int değer olarak 1 değerini alıyoruz 
        /// string ifadenin int 'a dönüşümü yapılmaktadır.
        /// Eğer "" - '0' "" ifadesi yazılmasaydı değer 49 olarak gözükecekti.
        /// </summary>
        /// <param name="ifade"></param>
        /// <returns>Int türünde bir dizi</returns>
        public static int[] StringIfadeyiIntDiziyeCevir(string ifade)
        {
            int[] dizi = new int[ifade.Length];
            for (int i = 0; i < ifade.Length; i++)
                dizi[i] = ifade[i] - '0';        // '0' char değerinin çıkarılmasıyla elde edilen int değer
            return dizi;
        }
        
        /// <summary>
        /// Paremetre olarak alınan string ifadenin paremetre olarak alından karakter değerinin ifadeden çıkarılma işlemi
        /// </summary>
        /// <param name="ifade"></param>
        /// <param name="karakter"></param>
        /// <returns>string değişken türünde tek boyutlu dizi</returns>
        public static string[] IfadeyiKarakterCikararakDiziyeCevir(string ifade, char karakter = ',')
        {
            return ifade.Split(karakter);
        }
        
        /// <summary>
        /// int değişken türünde tek boyutlu dizinin konsola bastırılma işlemi
        /// </summary>
        /// <param name="dizi"></param>
        public static void Yazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
                Console.Write("{0,5}", dizi[i]);
            Console.WriteLine();
        }
        
        /// <summary>
        /// Paremetre olarak alınan string ifadenin konsola renkli ve formatlı yazımı
        /// </summary>
        /// <param name="mesaj"></param>
        public static void YazdirConsoleRenkliHata (string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\a\n{0}\a\n", mesaj);
            Console.ResetColor();
        }
        
        /// <summary>
        /// Paremetre olarak verilen string ifadenin içindeki sesli harf sayısını bulan ve geri döndüren fonksiyon
        /// </summary>
        /// <param name="ifade"></param>
        /// <returns>int türünde sesli harf sayısı</returns>
        public static int IfadeIcindekiSesliHarfSayisi(string ifade)
        {
            int sesliHarfSayisi = 0;
            char[] sesli = { 'A', 'a', 'E','e', 'I', 'ı', 'İ', 'i', 'O', 'o', 'Ö', 'ö', 'U', 'u', 'Ü', 'ü'};
            for (int i = 0; i < ifade.Length; i++)
                for (int j = 0; j < sesli.Length; j++)
                    if (ifade[i] == sesli[j])
                        sesliHarfSayisi++;                
            return sesliHarfSayisi;
        }
    }
}
