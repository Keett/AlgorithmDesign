using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Cizim
{
    public class Elips : Sekil
    {
        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Elips, ");
            base.Tasi(yeniPozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genişlik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
