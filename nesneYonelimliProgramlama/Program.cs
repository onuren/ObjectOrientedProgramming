using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneYonelimliProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region öğrenci
            //Ogrenci ogr = new Ogrenci();
            ////field
            //ogr.isim = "onur";
            //ogr.soyad = "engün";
            //ogr.tcno = "1865865268";
            //ogr.yas = 26;

            //Ogrenci ogr2 = new Ogrenci();
            //ogr2.isim = "alp";
            //ogr2.soyad = "sarıkışla";
            //ogr2.tcno = "156486418653";
            //ogr2.yas = 28;

            //Console.WriteLine(ogr.isim + " " +ogr.soyad);
            //Console.WriteLine(ogr2.isim+ " " +ogr2.soyad);
            #endregion

            #region kitapçı

            kitapci ktp = new kitapci();
            ktp.kitapAdi = "asd";
            ktp.yazar = "asd";
            ktp.yayinEvi = "pusula";
            ktp.fiyat = 25.90; 

            #endregion
        }
    }
    class Ogrenci
    {
        public string isim;
        public string soyad;
        public string tcno;
        public byte yas;
    }
    class kitapci
    {
        public string kitapAdi;
        public string yazar;
        public string yayinEvi;
        public double fiyat;
    }
}
