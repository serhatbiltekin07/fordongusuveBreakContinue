﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forDongusuveBreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i % 2 ==1)
                {
                    Console.WriteLine(i);
                }
                
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; // tekToplam = tekToplam + i;
                }
                else
                {
                    ciftToplam += i; // ciftToplama = ciftToplam + i;
                }
                Console.WriteLine("tekToplam:" + tekToplam);
                Console.WriteLine("cifToplam:" + ciftToplam);                                           
            }


            // break, contiune
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            // break, contiune
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
