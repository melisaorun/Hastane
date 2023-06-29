using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Faturalar
    {
        private int _FaturaNo;
        private string _Odeme;
        private int _HastaNo;
        public int FaturaNo
        {
            get { return _FaturaNo; }
            set { _FaturaNo = value; }
        }
        public string Odeme
        {
            get { return _Odeme; }
            set { _Odeme = value; }
        }
        public int HastaNo
        {
            get { return _HastaNo; }
            set { _HastaNo = value; }
        }
    }
}
