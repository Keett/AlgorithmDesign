using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Cizim
{
    class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            Console.WriteLine("Derived Classes (Türetilmiş Sınıf) -> constractor");
        }

        public Dikdortgen(int genislik, int yukseklik, int x, int y) : base(genislik,yukseklik,x,y)
        {
            Console.WriteLine("Derived Classes -> constructor Dikdortgen");
        }

        public override void Ciz() => Console.WriteLine($"Dikdörtgen : {Pozisyon} - {Boyut}");

        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Dikdörtgen, ");
            base.Tasi(yeniPozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genişlik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
