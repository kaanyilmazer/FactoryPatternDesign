using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDesign.Classes
{
    public class Creator
    {
        public IUrunler FactoryMethod(UrunTipi urunTipi)
        {
            IUrunler urun = null;

            IUrunler urun1 = new Urun1();
            IUrunler urun2 = new Urun2();
            IUrunler urun3 = new Urun3();
            ;
            switch (urunTipi)
            {
                case UrunTipi.Urun1:
                    urun = new Urun1();
                    break;
                case UrunTipi.Urun2:
                    urun = new Urun2();
                    break;
                case UrunTipi.Urun3:
                    urun = new Urun3();
                    break;
            }
            return urun;


        }

    }
    
}
