using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesign.Classes
{
    public class Urun1 : IUrunler
    {
        public string SiparisFormu()
        {
            return "Kastamonudan Gelen Ürünler";
        }
    }
}
