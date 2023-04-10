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


          //  #region KararYapıları

          
            int s2;
            string opt = "";
            Console.WriteLine("Lütfen birinci sayıyı girin");
           int  s1 = Convert.ToInt32(Console.ReadLine());

            git:


            Console.WriteLine("Lütfen operator girin : +,-,*,/");
            opt = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Lütfen ikinci sayıyı girin");
            s2 = Convert.ToInt32(Console.ReadLine());


            //Klavyeden girilen 2 sayının toplamı
            if (opt == "+")
            {

                var sonuc = s1 + s2;
          

                s1 = sonuc;
                Console.Clear();
                Console.WriteLine($"Sayıların toplamı {s1}");


                goto git;

                ////veya
                //Console.WriteLine("Sayıların toplamı {0}", sonuc);

                ////veya şeklinde yazdırabiliriz.
                //Console.WriteLine("Sayıların toplamı {0}" + sonuc);

            }



            else if (opt == "-")
            {
                var sonuc = s1 - s2;


                s1 = sonuc;
                Console.Clear();
                Console.WriteLine($"Sayıların toplamı {s1}");
                goto git;


                ;

            }

            else if (opt == "*")
            {
                var sonuc = s1 * s2;


                s1 = sonuc;
                Console.Clear();
                Console.WriteLine($"Sayıların toplamı {s1}");
                goto git;

                ;

            }


            else if (opt == "/")
            {
                var sonuc = s1 / s2;


                s1 = sonuc;
                Console.Clear();
                Console.WriteLine($"Sayıların toplamı {s1}");
                goto git;



            }


            else
            {
                Console.WriteLine("Sayıları sıfırdan büyük giriniz");
            }
            Console.ReadLine();


        }
    }
}
