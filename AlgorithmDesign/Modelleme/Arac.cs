using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modelleme
{
    class Arac : Tasit
    {
        #region Field değişkneleri
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Property tanımlamaları - Kapsülleme işlemi yapıldı
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region constructions
        public Arac()
        {

        }
        public Arac(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }
        #endregion

        #region Methods
        public void Calistir() => Console.WriteLine("Araba Çalıştı");
        public void Durdur() => Console.WriteLine("Araba Durdu");
        public override string ToString()
        {
            Console.WriteLine($"Araç bilgileri: {Marka}, {Model}, {Renk}, {Yil}, {Motor}, {Hacim}");
            return Marka + " " + Model;
        }
        #endregion

    }
}
