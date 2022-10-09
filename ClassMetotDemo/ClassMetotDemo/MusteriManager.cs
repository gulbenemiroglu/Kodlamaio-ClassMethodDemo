using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Name} {musteri.LastName} sisteme eklendi");

        }

        public void MusteriUpdate(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Name} {musteri.LastName} sistemde güncellendi");
        }

        public void MusteriDelete(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Name} {musteri.LastName} sistemden silindi");
        }
    }
}
