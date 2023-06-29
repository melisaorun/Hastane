using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity
{
    public class Randevular
    {
        private int _RandevuNo;
        private DateTime _RandevuTarihi;
        private string _Saat;
        private int _HastaNo;
        private int _DoktorNo;

        public int RandevuNo
        {
            get { return _RandevuNo; }
            set { _RandevuNo = value; }
        }
        public DateTime RandevuTarihi
        {
            get { return _RandevuTarihi; }
            set { _RandevuTarihi = value; }
        }
        public string Saat
        {
            get { return _Saat; }
            set { _Saat = value; }
        }
        public int HastaNo
        {
            get { return _HastaNo; }
            set { _HastaNo = value; }
        }
        public int DoktorNo
        {
            get { return _DoktorNo; }
            set { _DoktorNo = value; }
        }
    }
}
