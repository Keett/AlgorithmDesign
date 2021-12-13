using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Cizim
{
    public sealed class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X: {X} , Y: {Y}";
    }
    public sealed class Boyut
    {
        public int Genişlik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString() => $"Genişlik: {Genişlik}, Yükseklik: {Yukseklik}";
    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base class -> constructor Sekil");
        }
        public Sekil(int genislik, int yukseklik, int x, int y)
        {
            Boyut = new Boyut { 
                Genişlik = genislik, 
                Yukseklik = yukseklik 
            };
            Pozisyon = new Pozisyon { X = x, Y = y };   
        }
        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get; } = new Boyut();

        /// <summary>
        /// virtual tanımlama bu metodun override edileceğini belirtir.
        /// </summary>
        public virtual void Ciz() => Console.WriteLine($"Şekil : {Pozisyon} - {Boyut}");
        public virtual void Tasi(Pozisyon yeniPozisyon)
        {
            Pozisyon.X = yeniPozisyon.X;
            Pozisyon.Y = yeniPozisyon.Y;
            Console.WriteLine($"yeni pozisyon değerlerine taşındı: {Pozisyon}");
        }
        public abstract void YenidenBoyutlandir(int genislik, int yukseklik);
    }
}
