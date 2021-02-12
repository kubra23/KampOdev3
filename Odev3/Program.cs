using System;
using System.Collections.Generic;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> Meslek = new Dictionary<int,string>();
            Meslek.Add (1,"Mühendis");
            Meslek.Add(2, "Hemşire");
            Meslek.Add(3, "Öğretmen");
            Meslek.Add(4, "Polis");

            Console.WriteLine("Meslek No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Meslek[No]);

            }
            catch 
            {

                Console.WriteLine("Meslek Bulunamadı.");
            }


        }
    }
}
