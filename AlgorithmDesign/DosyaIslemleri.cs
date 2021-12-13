using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace ConsoleApp1
{
    class DosyaIslemleri
    {
        /// <summary>
        /// Poje dosyasında dosya ismi adında bir txt. dosyası oluşturur ve oluşturulan dosyanın fiziksel konumunu geri döndürür.
        /// Eğer dosya var ise onun fiziksel konumunu geri döndürür.
        /// </summary>
        /// <returns>string türünde dosyaYolu uzantısı geri döner</returns>
        public static string DinamikKonumAtama(string dosyaIsmi)
        {
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYolu = "";
            for (int i = 0; i < yol.Length - 3; i++)
            {
                dosyaYolu += yol[i] + '\\';
            }
            dosyaYolu += dosyaIsmi;
            Console.WriteLine("{0} adlı txt dosyası {1} dosya yoluna başarıyla projeye eklendi.", dosyaIsmi,dosyaYolu);
            return dosyaYolu;
        }
        
        /// <summary>
        /// Varolan dosyadan değerleri okur ve konsola satır satır yazdırır.
        /// </summary>
        /// <param name="dosyaYolu"></param>
        public static void DosyadanDegerOkuKonsolaYaz(string dosyaYolu)
        {
            using (StreamReader sR = new StreamReader(dosyaYolu))
            {
                string line;
                while ((line = sR.ReadLine()) != null)
                    Console.WriteLine(line);

            }
        }

        /// <summary>
        /// Paremetre olarak aldığı string listesini dosya yolunda bulunan txt dosyasına ekler.
        /// </summary>
        /// <param name="dosyaYolu">Elemanların ekleneceği dosya yolu</param>
        /// <param name="liste">Eklenecek elemanların listesi</param>
        public static void DosyayaListeYaz(string dosyaYolu, string[] liste)
        {
            using (StreamWriter sW = new StreamWriter(dosyaYolu))
            {
                foreach (string item in liste)
                    sW.WriteLine(item);
                Console.WriteLine("\n Listedeki elemanlar txt dosyasına eklendi");
            }
        }

        /// <summary>
        /// FileStream sınıfı ile var olan dosyaya verilen izinler neticesinde veri ekleme işlemi
        /// </summary>
        /// <param name="dosyaYolu"></param>
        public static void VarOlanDosyayaVeriEkleme(string dosyaYolu)
        {
            string veri = "";
            FileStream fs = new FileStream(dosyaYolu,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None);
            while (veri != "cikis")     //çıkış yapıldığı kontrol edilmezse dosya üzerinde başka biri işlem yapıyor denilenerek erişim hatası alınır.
            {
                Console.Write("\n Dosyaya kaydetmek üzere veri giriniz: ");
                veri = Console.ReadLine();
                if (veri != "cikis")
                {
                    if (fs.CanWrite)
                    {
                        byte[] yaz = Encoding.UTF8.GetBytes(veri);
                        fs.Write(yaz, 0, yaz.Length);
                        fs.WriteByte(13);       //13 ifadesi enter' a denk gelmektedir.
                    }
                    else
                        Console.WriteLine("Dosyaya veri yazma izniniz bulunmuyor.");
                }
            }
            fs.Close();
        }

        /// <summary>
        /// Paremetre olarak aldığı dosyaYolu'ndaki dosya bilgilerini ekrana yazdırır
        /// </summary>
        /// <param name="dosyaYolu"></param>
        public static void DosyaBilgisi(string dosyaYolu)
        {
            var dosyaBilgisi = new FileInfo(dosyaYolu);
            Console.WriteLine("Dosyanın full ismi: {0}\n" + 
                "Dosya ismi: {1}\n" +
                "Dosyanın uzunluğu: {2}\n" +
                "Dosyanın oluşturulma zamanı: {3}\n" +
                "Dosyanın extension bilgisi: {4}\n" +
                "Dosyaya son erişim zamanı: {5}\n", dosyaBilgisi.FullName, dosyaBilgisi.Name, dosyaBilgisi.Length, dosyaBilgisi.CreationTime, dosyaBilgisi.Extension, dosyaBilgisi.LastAccessTime);
        }                                            

        /// <summary>
        /// Dosyayı hedef konuma kopyalar.
        /// </summary>
        /// <param name="hedef">Dosyanın kopyalanacağı hedef dosya yolu</param>
        /// <param name="kaynak">Dosyanın orijinal bulunduğu kaynak dosya yolu</param>
        public static void DosyaKopyala(string hedefYolu, string kaynakYolu)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynakYolu);
                fi.CopyTo(hedefYolu);
                Console.WriteLine("{0} kaynaklı dosya {1} dosyası olarak kopyalandı.", kaynakYolu, hedefYolu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Paremetre olarak aldığı dosyaYolundaki dosyayı kalıcı olarak siler
        /// </summary>
        /// <param name="dosyaYolu">Silinecek dosyanın dosya yolu</param>
        public static void DosyaSil(string dosyaYolu)
        {
            try
            {
                FileInfo fi = new FileInfo(dosyaYolu);
                fi.Delete();
                Console.WriteLine("Belirtilen dosya silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }

        }
    }                                               
}                                                    
