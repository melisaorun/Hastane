using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Doktorlar
    {
        private int _DoktorNo;
        private int _TC;
        private string _AdiSoyadi;
        private DateTime _DogumTarihi;
        private string _Cinsiyet;
        private int _Telefon;
        private string _UzmanlikAlani;

        public int DoktorNo
        {
            get { return _DoktorNo; }
            set { _DoktorNo = value; }
        }
        public int TC
        {
            get { return _TC; }
            set { _TC = value; }
        }
        public string AdiSoyadi
        {
            get { return _AdiSoyadi; }
            set { _AdiSoyadi = value; }
        }
        public DateTime DogumTarihi
        {
            get { return _DogumTarihi; }
            set { _DogumTarihi = value; }
        }
        public string Cinsiyet
        {
            get { return _Cinsiyet; }
            set { _Cinsiyet = value; }
        }
        public int Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }
        public string UzmanlikAlani
        {
            get { return _UzmanlikAlani; }
            set { _UzmanlikAlani = value; }
        }

    }
}
