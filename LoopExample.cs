

//klavyeden girilen pozitif ve negatif sayıları kontrol et, örneğin 5 ise 5 'e kadar olan sayıları bul ve tek sayıları ayrı topla, çiftleri ayrı topla


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {


int sayi;
            int toplamC = 0;
            int toplamT = 0;
            Console.WriteLine("Lütfen Bir Sayıyı Giriniz:");
            basa:
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >0)
            {
                Console.WriteLine("Sayı pozitif");

                for (int i = 1; i < sayi; i++)
                {

                    if (i%2 ==0)
                    {
                        Console.WriteLine($"{i} Sayısı çifttir");
                        toplamC = toplamC + i;
                        
                    }

                    else
                    {
                        Console.WriteLine($"{i} Sayısı tektir");
                        toplamT = toplamT + i;

                    }

                }

                Console.WriteLine($"Çift sayıların toplamı: {toplamC}\n");
                Console.WriteLine($"Tek sayıların toplamı: {toplamT}\n");

            

            }

            else
            {
                Console.WriteLine("Sayı negatif, pozitif bir sayı gir lütfen");
                goto basa;

            }




    

        }
    }
}
