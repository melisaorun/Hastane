using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BLRandevular
    {
        public static int Yurut(Randevular randevular)
        {
            if (randevular.RandevuTarihi > DateTime.Now)
            {
                return FRandevular.Ekle(randevular);
            }
            return -1;
        }
    }
}
