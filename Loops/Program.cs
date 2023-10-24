﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();    // Alanı seçip Edit - Refactor - extract method denince otomatik kendi oluşturdu.

            //WhileLoop();

            //DoWhileLoop();  //Mutlaka bir kere olsun çalışsın dersek kullanabiliriz.

            //ForEachLoop();

            if(IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");

            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i< number-1; i++)
            {
                if(number%i==0)
                {
                    result = false;
                    //i = number;  false olunca duraksa i ye number değeri ver bir daha döngüye girmez biter.
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {   //foreach içinde döndüğünüz elemanları değiştiremiyorsunuz
                //VERİTABANINDAN TABLO ÇEKMEK için sıklıkla kullanılır.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now nomber is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}