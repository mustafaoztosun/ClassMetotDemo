using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteriler Listeye Eklendi: " + musteri.Id + " : " + musteri.Adi + " : " + musteri.Soyadi + " : " + musteri.KimlikNo );
        }
    }
}
