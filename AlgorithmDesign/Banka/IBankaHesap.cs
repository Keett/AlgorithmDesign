using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Banka
{
    interface IBankaHesap
    {
        void ParaYatir(decimal miktar);
        bool ParaCekVeKontrolEt(decimal miktar);
        decimal Bakiye { get; }
    }
}
