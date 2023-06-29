using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace Business
{
    public class BLHastalar
    {
        public static int Yurut(Hastalar hastalar)
        {
            if (hastalar.AdSoyad != null && hastalar.AdSoyad.Trim().Length > 0)
            {
                return FHastalar.Ekle(hastalar);
            }
            return -1;
        }
    }
}
