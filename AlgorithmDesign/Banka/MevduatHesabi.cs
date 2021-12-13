using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Banka
{
    class MevduatHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool ParaCekVeKontrolEt(decimal miktar)
        {
            if(_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\n Bakiye yetersizdir.");
            return false;
        }

        public void ParaYatir(decimal miktar) => _bakiye += miktar;

        public override string ToString() => $"Mevduat hesabı bakiye bilgisi: {_bakiye,6:C}";
    }
}
