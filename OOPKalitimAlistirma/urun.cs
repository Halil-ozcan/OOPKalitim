using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimAlistirma
{
    public class urun : BaseClass
    {
        public  string marka{ get; set; } // belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin.
        public  string model{ get; set; }

        private decimal _alisFiyati;
        public  decimal alisFiyati{ get { return alisFiyati; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("Alis Fiyati 0 dan Küçük veya eşit olamaz.");
                }
                else
                {
                    alisFiyati = value;
                }
            } 
        } // 0 dan kucuk olmamalı

        private decimal _satisFiyat;
        public  decimal satisFiyati{ get { return _satisFiyat; }
            set
            {
                if(value < _alisFiyati)
                {
                    Console.WriteLine("Alis Fiyatindan Küçük olamaz");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        }  // alis fiyatindan kucuk olmaz

        private decimal _kampanyaFiyat;
        public  decimal kampanyaFiyat{ get { return _kampanyaFiyat; }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Kampanya Fiyati 0 dan küçük veya eşit olamaz");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            } 
                
        } // kampanya fiyat değeri 0 dan küçük olmaz.

    }
}
