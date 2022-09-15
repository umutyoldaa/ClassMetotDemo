using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine(musteri.Isim + "Sisteme eklendi");
            


        }
        public void MusteriListe(Musteri[] musteri)
        {
            foreach (Musteri custo in musteri)
            {
                if (custo.Id == 0)
                {

                }
                else
                {
                Console.WriteLine(custo.Id);
                Console.WriteLine(custo.Isim);
                Console.WriteLine(custo.SoyIsim);
                Console.WriteLine(custo.TcNo);
                }
            }
        }
    
        public void MusteriSilme(Musteri musteri)
        {
            musteri.Isim = "0";
            musteri.Id = 0;
            musteri.SoyIsim = "0";
            musteri.TcNo = 0;
            Console.WriteLine("bilgiler silindi");

        }
    }
}
