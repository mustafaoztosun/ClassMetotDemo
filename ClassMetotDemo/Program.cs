using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123546;
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Öztosun";
            musteri1.KimlikNo = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1254646;
            musteri2.Adi = "İsmail";
            musteri2.Soyadi = "Akçuru";
            musteri2.KimlikNo = 22222222222;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3154665;
            musteri3.Adi = "Tugay";
            musteri3.Soyadi = "Şaşkan";
            musteri3.KimlikNo = 33333333333;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.KimlikNo);
                Console.WriteLine("--------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

        }
    }
}
