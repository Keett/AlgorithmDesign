using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Banka
{
    class AktifHesap : ITransfer
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool ParaCekVeKontrolEt(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\n Bakiye yetersizdir.");
            return false;
        }

        public void ParaYatir(decimal miktar) => _bakiye += miktar;

        public bool TransperYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = ParaCekVeKontrolEt(miktar);
            if (sonuc)
            {
                aliciHesap.ParaYatir(miktar);
            }
            return sonuc;
        }

        public override string ToString() => $"Aktif hesap bakiye bilgisi: {_bakiye,6:C}";
    }
}
