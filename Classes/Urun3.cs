using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesign.Classes
{
    public class Urun3 : IUrunler
    {
        public string SiparisFormu()
        {
            return "Hataydan Gelen Urunler";
        }
    }
}
