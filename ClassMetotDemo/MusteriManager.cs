﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Listeye Eklendi: " + musteri.Id + " : " + musteri.Adi + " : " + musteri.Soyadi + " : " + musteri.KimlikNo );
        }
    }
}
