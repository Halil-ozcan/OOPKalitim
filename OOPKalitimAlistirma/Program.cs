using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            //B1.id = 1;
            B1.marka = "Lenova";
            B1.model = "z50";
            B1.islemci = "I5";
            B1.alisFiyati = 35000;
            B1.satisFiyati = 50000;
            B1.kampanyaFiyat = 10000;
            B1.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B1);


            bilgisayar B2 = new bilgisayar();
            //B1.id = 1;
            B2.marka = "Lenova";
            B2.model = "z50";
            B2.islemci = "I5";
            B2.alisFiyati = 35000;
            B2.satisFiyati = 50000;
            B2.kampanyaFiyat = 10000;
            B2.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B2);
        }
    }
}
