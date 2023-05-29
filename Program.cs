using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace HW3_ksh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //exer1
            int a, b;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if ((a * b) < 0)

            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("false"); }




            // exer2

            int c, d;

            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());


            if (c == 20 || d == 20)
            {
                Console.WriteLine("true");
            }


            if ((c + d) == 20)
            {

                Console.WriteLine("true");
            }
            Console.WriteLine("false");

            //EXER 3

            int number = 1;


            while (number < 100)
            {

                if (number % 2 != 0) { Console.Write("\n" + number); }


                number++;
            }

            //EXER 4
            


            int sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine("\nSum of the first 500 prime numbers: " + sum);


            //exer 5

            Console.WriteLine("Input  a number(integer): ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            while (n1 != 0)
            {
                sum1 += n1 % 10;
               
                n1 /= 10;
                
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum1);

        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;

        }



    }
    }



