using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modelleme
{
    class Tasit
    {
        public string Motor { get; set; }
        public double Hacim { get; set; }
        public void Temizle() => Console.WriteLine("Taşıt temizlendi.");
    }
    public enum Motor
    {
        Dizel,
        Benzin,
        LPG,
        Elektrik,
        Jet
    }
    public enum Renk
    {
        Beyaz, 
        Siyah, 
        Kirmizi, 
        Mavi
    }

}
