using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Banka
{
    interface ITransfer : IBankaHesap
    {
        bool TransperYap(IBankaHesap aliciHesap, decimal miktar);
    }
}
