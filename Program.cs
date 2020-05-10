using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*           Console.Write("podaj imię i nazwisko:");

                       string zmienna;
                       zmienna = Console.ReadLine();
                       Console.WriteLine("Witaj, {0}!", zmienna);
                       Console.ReadKey();
                       */

            /*Console.WriteLine("podaj liczbe 1:");
            int l1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj liczbe 2:");
            int l2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj liczbe 3:");
            int l3 = Convert.ToInt32(Console.ReadLine());

            int min = l1;
            if (l2 < min)
                min = l2;
            if (l3 < min)
                min = l3;
            Console.WriteLine("Minimum to {0}", min);
            int max = l1;
            if (l2 > max)
                max = l2;
            if (l3 > max)
                max = l3;
            Console.WriteLine("Maximum to {0}", max);
                double średnia = (l1 + l2 + l3) / 3;
            Console.WriteLine("średnia to {0}", średnia);
            Console.ReadKey()*/




            /* Console.WriteLine("podaj rok");
             int rok = Convert.ToInt32(Console.ReadLine());
             if (((rok%400 == 0) && (rok%100 !=0))  || (rok%400 == 0))
             Console.WriteLine("rok {0} przystepny", rok);
             else
             Console.WriteLine("rok {0} nie przystepny", rok);
             Console.ReadKey();
         }*/
            /*  Console.WriteLine("podaj liczbę od 1 do 12");
              int miesiac = Convert.ToInt32(Console.ReadLine());
              switch (miesiac)
              {
                  case 1:
                      Console.WriteLine("Styczeń");
                      break;
                  case 2:
                      Console.WriteLine("luty");
                      break;
                  case 3:
                      Console.WriteLine("marzec");
                      break;
                  case 4:
                      Console.WriteLine("kwiecien");
                      break;
                  case 5:
                      Console.WriteLine("maj");
                      break;
                  case 6:
                      Console.WriteLine("czerwiec");
                      break;
                  case 7:
                      Console.WriteLine("lipiec");
                      break;
                  case 8:
                      Console.WriteLine("sierpien");
                      break;
                  case 9:
                      Console.WriteLine("wrzesien");
                      break;
                  case 10:
                      Console.WriteLine("pazdziernik");
                      break;
                  case 11:
                      Console.WriteLine("listopad");
                      break;
                  case 12:
                      Console.WriteLine("grudzien");
                      break;
                  default: Console.WriteLine("to juz nie miesiac");
                      break;
              }
              Console.ReadKey();*/


            //  Console.WriteLine("Podaj liczbę");
            //int liczba = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i <= liczba; i++) 
            //Console.WriteLine("{0}, ", Math.Pow(2, i)); 
            // Console.ReadKey();


            //                int n, suma=0;
            //    Console.WriteLine("podaj");
            //    if (Int32.TryParse(Console.ReadLine(), out n))
            //        for (int i = 1; i <= n; i++)
            //            suma += i;
            //   Console.WriteLine("1 + ... + {0}={1},",n, suma);
            //    Console.ReadKey();


          /* for (int j = 1; j <=1000; j++)
              {
                  for (int i = 1; i <= 1000; i++)

                      Console.Write(i*j + " ");
                      Console.WriteLine();
               }
              Console.ReadKey();
*/


            /*   for (int i = 1; i <= 1000; i++)
               {
                   if (i % 3 ==0 || i % 11==0  || i % 5==0) 
                   Console.WriteLine(i);
               }
               Console.ReadKey();


              for (int j = 0; j <= 10; j++)
                 {
                     for (int i = 0; i < j; i++)
                         Console.Write("*\t", i*j);
                     Console.WriteLine();
                 }
            Console.WriteLine();
                

                 for (int i = 10; i > 0; i--)
                 {
                     for (int j = 0; j < i; j++)
                         Console.Write("*\t", i * j);
                     Console.WriteLine();
                 }
                 


                 for (int j =0; j < 10; j++)
                 {for (int i =0; i<j; i++)
                         Console.Write("\t");
                     for (int i = 10; i > j; i--)
                         Console.Write("*\t", i * j);
                     Console.WriteLine();
                 }
          */       

            for (int j = 10; j >= 0; j--)
            {
                for (int i = 0; i < j; i++)
                    Console.Write("\t");
                for (int i = 10; i > j; i--)
                    Console.Write("*\t", i * j);
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            int i = 1;
                while (i <=100)
            {
                Console.WriteLine(i);
                i += 3;
            }
            Console.ReadKey();
            
            int a, suma = 0;
           
            do
            {
             a = Convert.ToInt32(Console.ReadLine());
                suma += a;
                Console.WriteLine("suma {0}; podaj kolejna: ", suma);
            }

            while (a !=0);
           
          
            Console.ReadKey();*/

/*
            int a, silnia = 1;
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0) 
            {
                silnia *= a;
                a--;
           
               
            }
Console.WriteLine(silnia); 
   
            Console.ReadKey();*/

/*
            string[] tablica = new string[4] { "n1", "n2", "n3", "n4"};
            int i;
            for (i = 0; i< 4; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();


            string[] tablica = new string[4] { "n1", "n2", "n3", "n4" };
            foreach(string element in tablica)
                Console.WriteLine(element);

            Console.ReadKey();
            /*



           /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            int[] tablica = new int[10] { a, b, c, d, e, f, g, h, q, w };
           


            for (int j=0; j< tablica.Length; j++)
            


            Console.ReadKey();
            Random generator = new Random();
            int[] liczby = new int[10];
            int i = 0;

            while (i < 10)
            {
                liczby[i] = generator.Next(10);
                i++;
            }

            for (i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] % 2 == 0)
              Console.WriteLine(liczby[i]);
            }

            Random generator = new Random();
            int[] liczby = new int[10];
            int i = 0;
            for (i = 0; i < liczby.Length; i++)
                liczby[i] = generator.Next(1, 30);
            Console.WriteLine("średnia liczb z kolekcji");
            for (i = 0; i < liczby.Length; i++)
                suma += liczby[i];
            Console.WriteLine("\n{ 0}\n{1}", suma, (double) suma / 10);




            Random generator = new Random();
            int[] liczby = new int[10];
            int i = 0, min
                min = liczby[0];

            for (i = 0; i < liczby.Length; i++)
                if (liczby[i] < min)
                    min = liczby[i];

            Console.WriteLine("najmniejsza liczba z kolekcji:\n{0} ", min);*/
            




              

               

















        }
    }
}
