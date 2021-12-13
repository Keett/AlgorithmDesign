using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MatrisOlustur
    {
        /// <summary>
        /// Paremetre değerlerine bağlı olarak verile satır ve sutun boyutunda paremetrelerde verilen min - max arası değerlerine sahip elemanlar ile 2 boyutlu matris oluşturur.
        /// </summary>
        /// <param name="satir"></param>
        /// <param name="sutun"></param>
        /// <param name="min">Elemanların alabileceği en küçük değer</param>
        /// <param name="max">Elemanların alabileceği en büyük değer</param>
        /// <returns>Iki boyutlu matris</returns>
        public static int[,] MatrisiOlustur (int satir = 3, int sutun = 3, int min = 1, int max = 10)
        {
            int[,] dizi = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                    dizi[i, j] = new Random().Next(min, max);
            return dizi;
        } 

        /// <summary>
        /// Bütün elemanları 0 dan oluşan satir ve sutun değerlini paremetre olarak alan matris oluşturma
        /// </summary>
        /// <param name="satir"></param>
        /// <param name="sutun"></param>
        /// <returns>iki boyutlu int dizi</returns>
        public static int[,] SifirMatrisOlustur(int satir = 3, int sutun = 3)
        {
            int[,] dizi = MatrisiOlustur(satir, sutun,0,0);
            return dizi;
        }

        /// <summary>
        /// Bütün elemanları 1 den oluşan satir ve sutun değerlini paremetre olarak alan matris oluşturma
        /// </summary>
        /// <param name="satir"></param>
        /// <param name="sutun"></param>
        /// <returns>iki boyutlu int dizi</returns>
        public static int[,] BirlerMatrisOlustur(int satir = 3, int sutun = 3)
        {
            int[,] dizi = MatrisiOlustur(satir, sutun, 1, 1);
            return dizi;
        }

        /// <summary>
        /// Boyut değerini ve elemanları için min ve max değerlerini parametre olarak alır
        /// bütün elemanları ilk 0 elemanlarından oluşur (SIFIR MATRİS)
        /// diyegonel değerleri min max sayıları arasında random değer alırlar
        /// diyegonel elemanları random değerler alır diyegonel dışındaki elemanları 0'dır.
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>iki boyutlu int dizi</returns>
        public static int[,] KosegenMatrisOlustur(int boyut = 3, int min = 1, int max = 10)
        {
            int[,] dizi = SifirMatrisOlustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                for (int j = 0; j < boyut; j++)
                    if (i == j)
                        dizi[i, j] = new Random().Next(min, max);
            return dizi;
        }

        /// <summary>
        /// Boyut paremetresi ile satır ve sutünü eşit olan diyegpnel elemanları hariç diğer eleman değerleri 0 olan 
        /// ve diyegonel elemanlarına daha sonradan skalerDeger değerini üstüne yazan fonksiyon (KÖŞEGEN MATRİS)
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="skalerDeger"></param>
        /// <returns>iki boyutlu int dizi</returns>
        public static int[,] SkalerMatrisOlustur(int boyut = 3, int skalerDeger = 5)
        {
            return KosegenMatrisOlustur(boyut, skalerDeger, skalerDeger);
        }
        
        /// <summary>
        /// Skaler matris gibi diyegonel değerleri hariç diğer eleman değerleri : 0
        /// diyegonel elemanları ise 1 olan matris oluşturur. (SKALER MATRİS)
        /// </summary>
        /// <param name="boyut"></param>
        /// <returns>iki boyutlu int dizi</returns>
        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatrisOlustur(boyut, 1);

        }
        
        /// <summary>
        /// dizi[i,j] == dizi[j,i] --> i!=j şartıyla dizi oluştur
        /// yani oluşturulan bir köşegen matrisin eleman değerlerini transpoz matrisi ile eş olacak şekilde ataması yapılmıştır.
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>iki boyutlu matris</returns>
        public static int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int max = 10)
        {
            int[,] dizi = KosegenMatrisOlustur(boyut, min, max);
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = new Random().Next(min, max);
                    dizi[j, i] = dizi[i, j];
                }
            }
            return dizi;
        }

        /// <summary>
        /// Diyegonel elemanların altında kalan üçgen bölgesi elemanları 0 diğer elemanlar min-max arası değer alır
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>İki boyut dizi</returns>
        public static int[,] UstUcgenOlustur(int boyut = 3, int min = 1, int max = 10)
        {
            int[,] dizi = SifirMatrisOlustur(boyut, boyut);
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = i; j < dizi.GetLength(1); j++)
                    dizi[i, j] = new Random().Next(min, max);
            return dizi;
        }

        /// <summary>
        /// Diyegonel elemanların üstünde kalan üçgen bölgesi elemanları 0 diğer elemanlar min-max arası değer alır
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>İki boyut dizi</returns>
        public static int[,] AltUcgenOlustur(int boyut = 3, int min = 1, int max = 10)
        {
            int[,] dizi = SifirMatrisOlustur(boyut, boyut);
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j <= i; j++)
                    dizi[i, j] = new Random().Next(min,max);
            return dizi;
        }
    }
    class MatrisKontrol
    {
        /// <summary>
        /// Diyegonel elemanları 0'dan farklı ve diğer elemanları 0 olan 
        /// boyutu kare matris olacak şekilde oluşturulan dizinin kontrolü
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>bool değer</returns>
        public static bool KosegenMatrisMi(int[,] dizi)
        {
            bool kontrol = true;
            if (KareMatrisMi(dizi))
            {
                for (int i = 0; i < dizi.GetLength(0); i++)
                {
                    for (int j = 0; j < dizi.GetLength(1); j++)
                    {
                        if (dizi[i, j] != 0 && i != j)
                        {
                            kontrol = false;
                            break;

                        }
                        else if (dizi[i, j] == 0 && i == j)
                        {
                            kontrol = false;
                        }
                    }
                }
                return kontrol;
            }
            else
            {
                Console.WriteLine("Girilen matris kare matris değildir");
                return false;
            }
        }

        /// <summary>
        /// Satır ve sütun değerleri eşit olan matrisdir
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>bool değeri döndürür</returns>
        public static bool KareMatrisMi(int[,] dizi)
        {
            return dizi.GetLength(0) == dizi.GetLength(1) ? true : false;
        }

        /// <summary>
        /// İlk kare matris oluğ olmadığı kontrol edilir yani satır ve sutun değeri eşit mi kontrolü
        /// dizinin uzunluğuna kadar diyegonel elemanların dışındaki elemanların 0 olduğu ve diyegonel elemanların 1 olduğu durumda birim matrisdir.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>bool değer</returns>
        public static bool BirimMatrisMi(int[,] dizi)
        {
            bool kontrol = true;
            if (KareMatrisMi(dizi))
            {
                for (int i = 0; i < dizi.GetLength(0) && kontrol == true; i++)
                {
                    for (int j = 0; j < dizi.GetLength(1); j++)
                    {
                        //diyegonel elemanlar dışı 0 mı
                        if (dizi[i, j] != 0 && i != j)
                        {
                            kontrol = false;
                            break;
                        }
                        //diyegonel elemanlar 1 mi
                        else
                        {
                            if (dizi[i, j] != 1 && i == j)
                            {
                                kontrol = false;
                                break;
                            }
                        }
                    }
                }
            }
            else
                kontrol = false;
            return kontrol;
        }

        /// <summary>
        /// İki dizi simetrik mi yani dizi ve dizinin transpozu birbirine eşit mi
        /// dizi[i,j] == dizi[j,i] --> i!=j
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>bool değer</returns>
        public static bool SimetrikMi(int[,] dizi)
        {
            return MatrisKarsilastirma(dizi, Matris.MatrisTranspozu(dizi));
        }

        /// <summary>
        /// İki tane 2 boyutlu dizinin elemanlarının karşılaştırılması yapılmıştır.
        /// </summary>
        /// <param name="dizi_1"></param>
        /// <param name="dizi_2"></param>
        /// <returns>bool değer</returns>
        public static bool MatrisKarsilastirma(int[,] dizi_1, int[,] dizi_2)
        {
            bool kontrol = false;
            // iki matris boyutu eşit mi??
            if (dizi_1.GetLength(0) == dizi_2.GetLength(0) && dizi_1.GetLength(1) == dizi_2.GetLength(1))
            {
                for (int i = 0; i < dizi_1.GetLength(0); i++)
                {
                    for (int j = 0; j < dizi_1.GetLength(1); j++)
                    {
                        if (dizi_1[i, j] == dizi_2[i, j])
                            kontrol = true;
                        else
                        {
                            kontrol = false;
                            break;
                        }
                    }
                }
            }
            else
                Functions.YazdirConsoleRenkliHata("Verilen iki matrisin boyut uyuşmazlığı veya satir ve sutun sayısı uyuşmazlığı vardır.");
            return kontrol;
        }

        /// <summary>
        /// Diyegonel elemanlarının altında kalan eleman değerleri 0 mı
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        public static bool UstUcgenMi(int[,] dizi)
        {
            for (int i = dizi.GetLength(0) - 1; i > 0; i--)     //veya for (int i = 1; i < dizi.GetLength(0); i++)     
                for (int j = 0; j < i; j++)                     //         for (int j = 0; j <= i-1; j++)
                    if (dizi[i, j] != 0)
                        return false;
            return true;
        }

        /// <summary>
        /// Diyegonel üstü elemanların değerleri 0 mı kontrolü
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        public static bool AltUcgenMi(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0) - 1; i++)
                for (int j = i + 1; j< dizi.GetLength(1); j++)
                    if (dizi[i, j] != 0)
                        return false;
            return true;
        }
    }
    class Matris
    {
        /// <summary>
        /// Paremetre olarak aldığı 2 boyutlu matrisi konsola yazdırır.
        /// </summary>
        /// <param name="dizi"></param>
        public static void MatrisYazdir(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                    Console.Write("{0,5}", dizi[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Kare matris olup olmadığı kontrol edilir yani satır ve sütun sayısı eşitse
        /// diyegonel elemanları tek boyutlu bir diziye atar aksi halde hata mesajı görüntülenir.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns> tek boyutlu int dizi : diyegonel elemanların listesini tutar</returns>
        public static int[] DiyegonelElemanlarinListesi(int[,] dizi)
        {
            int[] elemanListesi = new int[dizi.GetLength(0)];
            if (MatrisKontrol.KareMatrisMi(dizi))
            {
                for (int i = 0; i < dizi.GetLength(0); i++)
                    elemanListesi[i] = dizi[i, i];
            }
            else
                Functions.YazdirConsoleRenkliHata("Kare Matris girmelisiniz");
            return elemanListesi;
        }

        /// <summary>
        /// Diyegonel elemanların toplamını hesaplar 
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns> trace : matris izi toplamını ifade eder</returns>
        public static int MatrisIzi(int[,] dizi)
        {
            int trace = 0;
            int[] diyegonelElemanlar = DiyegonelElemanlarinListesi(dizi);
            for (int i = 0; i < diyegonelElemanlar.Length; i++)
                trace += diyegonelElemanlar[i];
            return trace;
        }

        /// <summary>
        /// Matrisin transpozunu geri döndürür
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>iki boyutlu matris</returns>
        public static int[,] MatrisTranspozu(int[,] dizi)
        {
            int[,] transpozDizi = new int[dizi.GetLength(1), dizi.GetLength(0)];
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j < dizi.GetLength(1); j++)
                    transpozDizi[j, i] = dizi[i, j];
            return transpozDizi;
        }

        /// <summary>
        /// 2 Boyutlu dizi elemanlarını tek boyutlu diziye atama işlemi
        /// </summary>
        /// <param name="IkiBoyutluDizi"> İki boyutlu dizi</param>
        /// <returns> tek boyutlu dizi</returns>
        public static int[] IkiBoyutluDiziElemanlarınıTekBoyutluDiziyeAta(int[,] IkiBoyutluDizi)
        {
            int[] diziElemanları = new int[IkiBoyutluDizi.Length];
            int indis = 0;
            for (int i = 0; i < IkiBoyutluDizi.GetLength(0); i++)
            {
                for (int j = 0; j < IkiBoyutluDizi.GetLength(1); j++)
                {
                    diziElemanları[indis] = IkiBoyutluDizi[i, j];
                    indis++;
                }
            }
            return diziElemanları;
        }

        /// <summary>
        /// Girilen matrisinin yeniden şekillendirilmesi
        /// </summary>
        /// <param name="dizi">Şekillendirilecek 2 boyutlu dizi</param>
        /// <param name="yeniSatir"></param>
        /// <param name="yeniSutun"></param>
        /// <returns>2 boyutlu yeniden şekillendirilmiş dizi</returns>
        public static int[,] MatrisiYenidenSekillendir(int[,] dizi, int yeniSatir, int yeniSutun)
        {
            int[,] yeniDizi = new int[yeniSatir, yeniSutun];
            if (dizi.Length == yeniSatir * yeniSutun)
            {
                int[] tekBoyutlu = IkiBoyutluDiziElemanlarınıTekBoyutluDiziyeAta(dizi);
                Functions.Yazdir(tekBoyutlu);

                int indis = 0;
                for (int i = 0; i < yeniSatir; i++)
                {
                    for (int j = 0; j < yeniSutun; j++)
                    {
                        yeniDizi[i, j] = tekBoyutlu[indis];
                        indis++;
                    }
                }
                MatrisYazdir(yeniDizi);
            }
            else
            {
                Functions.YazdirConsoleRenkliHata("Boyut uyuşmazlığı");
            }
            return yeniDizi;
        }

        /// <summary>
        /// Paremetre olarak aldığı matrisin determinantını hesaplar
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>determinant değeri</returns>
        public static int Determinant(int[,] dizi)
        {
            int determinatDegeri = 0;
            if (MatrisKontrol.KareMatrisMi(dizi))
            {
                if (dizi.GetLength(0) == 2)
                    determinatDegeri = dizi[0, 0] * dizi[1, 1] - dizi[0, 1] * dizi[1, 0];
                else if (dizi.GetLength(0) == 3)
                    determinatDegeri = dizi[0, 0] * (dizi[1, 1] * dizi[2, 2] - dizi[1, 2] * dizi[2, 1]) -
                        dizi[0, 1] * (dizi[1, 0] * dizi[2, 2] - dizi[2, 0] * dizi[1, 2]) +
                        dizi[0, 2] * (dizi[1, 0] * dizi[2, 1] - dizi[1, 1] * dizi[2, 0]);
                else
                    Functions.YazdirConsoleRenkliHata("Girilen kare matris 2 veya 3 boyutlu değildir.");
            }
            else
            {
                Functions.YazdirConsoleRenkliHata("Kare matris olmayan matrislerin determinant hesabı yapılamaz.");
            }
            return determinatDegeri;
        }

        /// <summary>
        /// Scaler hesaplama yapar bir scaler değeri alır ve dizi elemanlarının hepsini scaler değer ile çarpılır.
        /// </summary>
        /// <param name="dizi"></param>
        /// <param name="skaler"></param>
        /// <returns>İki boyutlu dizi</returns>
        public static int[,] MatrisiBirDegerIleCarp(int[,] dizi, int skaler)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j < dizi.GetLength(1); j++)
                    dizi[i, j] *= skaler;
            return dizi;
        }

        /// <summary>
        /// Matris elemanları toplamı 
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>eleman değerlerinin toplamını geri döndürür</returns>
        public static int MatrisElemanlariToplami(int[,] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j < dizi.GetLength(1); j++)
                    toplam += dizi[i, j];
            return toplam;
        }
    }
}
