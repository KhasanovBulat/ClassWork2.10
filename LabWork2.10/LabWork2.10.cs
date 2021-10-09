using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2._10
{
    class Program
    {
        static void NumberComparing(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            if (num1 < num2)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("Числа равны друг другу");
            }
        }

        static void ChangePosition(ref double num1, ref double num2)
        {
            double temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"{num1}\n{num2}");
        }

        static bool FindTheFactorial(int num1, out int result)
        {
            {
                result = 1;
                for (int i = 2; i <= num1; i++)
                {
                    try
                    {
                        checked
                        {
                            result *= i;
                        }
                    }
                    catch (OverflowException)
                    {
                        result = 0;
                        return false;
                    }
                }
                return true;
            }

            static int RecursiveFactorial(int num)
            {
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    return num * RecursiveFactorial(num - 1);
                }
            }

            static int NOD(int a, int b)
            {
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                return a;
            }

            static int Fibonachi(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }




            static void Main(string[] args)
            {
                Console.WriteLine("5.1");
                Console.WriteLine("Введите первое число");
                double first_number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double second_number = Convert.ToDouble(Console.ReadLine());
                NumberComparing(first_number, second_number);

                Console.WriteLine("5.2");
                Console.WriteLine("Введите значение первого параметра");
                first_number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение второго параметра");
                second_number = Convert.ToDouble(Console.ReadLine());
                ChangePosition(ref first_number, ref second_number);

                Console.WriteLine("5.3"); // вывод результата
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                int result;
                FindTheFactorial(number, out result);
                Console.WriteLine("Факториал равен {0}", result);

                Console.WriteLine("5.4");
                Console.WriteLine("Введите число");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Факториал данного числа равен {0}", RecursiveFactorial(number));

                Console.WriteLine("Д.З. 5.1");
                Console.WriteLine("Алгоритм Евклида");
                Console.WriteLine("Введите 1 число");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 3 число");
                int number3 = Convert.ToInt32(Console.ReadLine());
                int NOD_3 = NOD(NOD(number1, number2), number3);
                Console.WriteLine("Наибольший общий делитель чисел {0} и {1} и {2} равен {3}", number1, number2, number3, NOD_3);

                Console.WriteLine("Д.З 5.2");
                Console.WriteLine("Введите порядковый номер числа ряда Фибоначчи:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число ряда Фибоначчи данного пор.номера равно {Fibonachi(n)}");
                
            }
        }
    } }
