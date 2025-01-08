using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    internal class TemelTip
    {
        // Ortak Özellik olan fieldlar

        public int id { get; set; }
        public string referansKod{ get; set; }
        public string isim{ get; set; }
        public string soyisim{ get; set; }
        public string cinsiyet{ get; set; }
        public DateTime kayitTarihi{ get; set; }
        public int kayitKullanici{ get; set; }
        public DateTime guncellemeTarihi{ get; set; }
        public int guncellemeKullanici{ get; set; }
        public bool silindi{ get; set; }


        public TemelTip()
        {
            Console.WriteLine("Temel Tip nesnesinin yapıcı metot çalıştı");
            IdAtamasi();
        }

        private void IdAtamasi()
        {
            Random random = new Random();
            this.id = random.Next(1000, 9000);
        }

        public void temelTipMetot1()
        {
            Console.WriteLine("Temel Tip => metot 1");
        }
    }
}
