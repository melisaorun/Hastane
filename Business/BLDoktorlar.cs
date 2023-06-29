using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace Business
{
    public class BLDoktorlar
    {
        public static int Yurut(Doktorlar doktorlar)
        {
            if (doktorlar.AdiSoyadi != null && doktorlar.AdiSoyadi.Trim().Length > 0)
            {
                return FDoktorlar.Ekle(doktorlar);
            }
            return -1;
        }
    }
}
