using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace Business
{
    public class BLFaturalar
    {
        public static int Yurut(Faturalar faturalar)
        {
            if (faturalar.Odeme != null && faturalar.Odeme.Trim().Length > 0)
            {
                return FFaturalar.Ekle(faturalar);
            }
            return -1;
        }
    }
}
