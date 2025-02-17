using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    internal class Personel:TemelTip
    {
        public DateTime isBaslangicTarihi{ get; set; }
        public DateTime isBitisTarihi{ get; set; }
        public int izinGunSayisi{ get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesi Yapıcı Metot Çalıştı");
        }
    }
}
