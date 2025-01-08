using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    internal class Egitmen:TemelTip
    {
        public string Brans { get; set; }
        public int BransSeviye{ get; set; }

        public DateTime isBaslangicTarihi { get; set; }
        public DateTime isBitisTarihi { get; set; }
        public int izinGunSayisi { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesi yapıcı metot çalıştı");
        }
    }
}
