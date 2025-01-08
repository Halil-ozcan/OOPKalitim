using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemelTip temelTip = new TemelTip();

            temelTip.temelTipMetot1();

            Egitmen egitmen = new Egitmen();
            Console.WriteLine("Eğitmen nesnesi örneklendi");
            egitmen.temelTipMetot1();

            // özel tiplerde boxing ve unboxing

            //bizim object nesnemiz nedir?
            //Temel Tip
            TemelTip T2;
            //hangi nesnelerde temel tip object görevi görür.
            //personel eğitmen ogrenci
            //temeltip nesnesinden türedikleri için temeltip nesnensi bu nesnelerde object gibi davranır.

            T2 = egitmen; // egitmen nesnesi temel tip nesnesine atandı.

            egitmen = (Egitmen)T2; // unboxing

            Personel personel = new Personel();
            T2 = personel; // personel nesnesi temel tip nesnesine atandı.

            personel = (Personel)T2;
 

            // Boxing -- UnBoxing

            object o1 = egitmen; // Boxing;
            egitmen = (Egitmen) o1; // UnBoxing;
           
        }
    }
}
