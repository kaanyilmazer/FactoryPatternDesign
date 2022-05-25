using System;
using FactoryPatternDesign.Classes;

namespace FactoryPatternDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();

            IUrunler urun1 = c.FactoryMethod(UrunTipi.Urun1);
            Console.WriteLine(urun1.SiparisFormu());

            Console.ReadKey();
        }
    }
}
