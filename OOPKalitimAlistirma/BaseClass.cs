using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimAlistirma
{
    public class BaseClass
    {
        public static int sayac = 1;  // ilk oluştuğu zaman 1 değerini otomatik olarak alsın.

        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private int _id;

        public int id { 
            get { 
                return _id;
            } 
            set {
                // bir sayac içerisindeki değerden faydalanmak istiyoruz.
                //_id = sayac;
                //sayac = sayac + 1;
                // nedeni basit set alanı private olarak işaretlendiği için değeri 0 olarak geliyor.
            } 
        }

        private string _barkod;
        public string barkod {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = sanalDatabase.dbBarkodKontrol(value);
                if(!kontrolIslemi) // değeri sanal database içerisinde bulamadım.
                {
                        barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal Database içerisinde bu barkod değeri daha önce girilmiştir.");
                } 
            }
        }

        public DateTime olusturmaTarihi { get; set; }
        public int  olusturanKullanici { get; set; }

        public DateTime guncellemeTarihi { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool  silindi{ get; set; }

    }
}
