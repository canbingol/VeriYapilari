using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Liste list = new Liste();
            list.liste();
            list.SonaEkle(10);
            list.SonaEkle(5);
            list.SonaEkle(20);
            list.SonaEkle(50);
            list.Yazdır();
            list.BasaEkle(45);
            list.Yazdır();


            Console.ReadKey();
        }







    }
}
