using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int result = Add2(20, 30);
            //Console.WriteLine(result);
            ////Console.WriteLine(Add2(20, 30));


            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1,number2);
            //Console.WriteLine(result2);

            //Console.WriteLine(number1);  
            // değer tipleri ile referans tiplerini ayırt etmemiz lazım
            //her zaman değer tipinin buradaki değeriyle ilgilenir, atanan değerle değil.
            // eğer REF (referans) ya da OUT tipiyle gönderirsek değeri de değişir.
            // Add3(ref number1, number2 )
            // int Add3(ref int number1, int number2) yazmalıyız. O zaman number1 =30 olacaktır.
            // Add3(out number1, number2) gibi , OUT da ilk değer atamasına gerek yok ama ref isteyecektir.
            //OUT da methodun içinde set edilmiş olmasını ister. Burada int number=20 demenin önemi yok
            //Add3 methodunda set etmiş değer vermiş olman gerekir.
            // ---------------------------------------------

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply2(2, 4, 5));
           
            Console.WriteLine(Add4(1,2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1, int number2)
        {
            // void demedik çünkü işlem yapılacak. Void işlem yapmıyor. Dönecek değer int olduğu için öyle tanımladık
            // default değerler her zaman methodun EN SONunda olmalı. Yani number=10 diyemeyiz, number2=10 diyebiliriz.
            // Eğer bu değer girilmezse number2 yi 10 olarak alır. Add2(20) dersek 20+10=30 yazacaktır.
            // Birden fazla default değeri verirsek hepsine yazabiliriz;
            // (int number1=10, int number2=20) gibi

            var result = number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;

        }
        static int Multiply2(int number1, int number2, int number3)  // aşırı yüklenme = overload
        {
            return number1 * number2 * number3;

        }

        static int Add4(params int[] numbers)
        {  //params formatıyla diziyi yollayabiliriz demek
            //Methodun parametresinin son parametresi olmak zorunda;
            // (params int[] numbers,int number )  YAZILAMAZ.
            return numbers.Sum();

        }

    }
}

