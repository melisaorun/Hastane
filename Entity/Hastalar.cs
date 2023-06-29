using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hastalar
    {
        private int _HastaNo;
        private int _TC;
        private string _AdSoyad;
        private DateTime _DogumTarihi;
        private string _Cinsiyet;
        private int _Telefon;
        private string _SosyalGuvenlik;

        public int HastaNo
        {
            get { return _HastaNo; }
            set { _HastaNo = value; }
        }
        public int TC
        {
            get { return _TC; }
            set { _TC = value; }
        }
        public string AdSoyad
        {
            get { return _AdSoyad; }
            set { _AdSoyad = value; }
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
        public string SosyalGuvenlik
        {
            get { return _SosyalGuvenlik; }
            set { _SosyalGuvenlik = value; }
        }

    }
}
