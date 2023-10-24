using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro(); 

            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");  //Doğruysa True döner.

            var result5 = sentence.IndexOf("name");  //eğer içermezse -1 döner, varsa kaçıncı karakterden başlarsa onu döner. (3)
            var result6 = sentence.IndexOf(" "); // ilk boşluğu döner = 2
            var result7 = sentence.LastIndexOf(" ");  //sondan aramaya başlar = 16.karakter
            var result8 = sentence.Insert(0, "Hello ");  //0.karakterden itibaren bunu ekle.
            var result9 = sentence.Substring(3, 4);// 3.karakter itibaren 4 tane al= name 
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2);   // 2.karakter dahil uçurur :D   Çıktısı = My
            var result14 = sentence.Remove(2,4);  // 2.den itibaren 4 tanesini uçurur :) name silinir.

            Console.WriteLine(result8);
            Console.WriteLine(result);
          

            
            
            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara"; // String kendi başına veri tipi olsa da aynı zamanda CHAR ARRAY dir.
            //Console.WriteLine(city[0]);  //A yazacak
            foreach (var item in city)
            {
                Console.WriteLine(item);

            }

            string city2 = "İstanbul";   // string result=  city1 + city2; yazarsak yanyana yazar.


            Console.WriteLine(String.Format("{0} {1}", city, city2));  //bellekte 3.bir değişken tanımlamamış oldu bu yönden önemli
        }
    }
}
