using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public class Ogrenci:TemelTip
    {
        public string bolum{ get; set; }
        public int seviye{ get; set; }


        public Ogrenci()
        {
            Console.WriteLine("ogrenci nesnesi yapıcı metot");
        }
    }
}
