using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //Долг
             Console.WriteLine("Задание 2.3");
             Console.WriteLine("Введите количество осадков за январь:");
             double precip_jan = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите количество осадков за март:");
             double precip_mar = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Среднедневное количество осадков за январь {0}", precip_jan);
             Console.WriteLine("Среднедневное количество осадков за январь {0}", precip_mar);

             Console.WriteLine("Задание 3.1");
             int numerator1 = 1;
             int numerator2 = 2;
             int denominator1 = 1;
             int denominator2 = 1;
             while (Math.Abs(numerator2 / denominator2 - numerator1 / denominator2) > 0.001);
             {
                 int numerator = numerator2;
                 int denominator = denominator2;
                 denominator2 += denominator1;
                 numerator2 += numerator1;
                 numerator1 = numerator;
                 denominator1 = denominator;
             }
             Console.WriteLine("Числитель = {0}/n Делитель = {1}", numerator2, denominator2);
            
            Console.WriteLine("Задание 3.3a");
            int number = 80;
            while (number >= 80 && number <= 100)
            {
                Console.WriteLine(number++);
            }

            Console.WriteLine("Задание 3.3б");
            number = 80;
            do
            {
                Console.WriteLine(number++);
            }
            while (number >= 80 && number <= 100);
            
            Console.WriteLine("Задание 3.4");
            int natural = (39 * (5000 / 39));
            Console.WriteLine(natural);

            Console.WriteLine("Задание 3.5");
            Console.WriteLine("5\n5 5\n5 5 5\n5 5 5 5\n5 5 5 5 5");
            Console.WriteLine("1 1 1 1 1\n1 1 1 1\n1 1 1\n1 1\n1");

            
























        }
    }
}
