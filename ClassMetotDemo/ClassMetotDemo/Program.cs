using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Gülşen";
            musteri1.LastName = "Emiroğlu";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Gülben";
            musteri2.LastName = "Emiroğlu";
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Bilge";
            musteri3.LastName = "Köksal";

            Musteri[] musteriler = new Musteri[3] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManeger = new MusteriManager();

            musteriManeger.MusteriAdd(musteri1);
            musteriManeger.MusteriUpdate(musteri2);
            musteriManeger.MusteriDelete(musteri3);

            Console.ReadKey();
        }
    }
}
