using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2._10
{
    class Program
    {

        public void Equation_solution(double a, double b, double c)

        {
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Первый корень - {0}\nВторой корень - {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Решения в действительных числах не существует");
            }
        }

        static int[] BubbleSort(int[] Array)
        {
            int temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        static public int Task4_sum(params int[] MyArray)
        {
            int sum = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                sum += MyArray[i];
            }
            return sum;
        }

        static public int Task4_Multplication(ref int[] MyArray)
        {
            int multipl = 1;
            for (int i = 0; i < MyArray.Length; i++)
            {
                multipl *= MyArray[i];
            }
            return multipl;
        }
        static public double Task4_Average(int[] MyArray, double average)
        {
            average = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                average += i;
            }
            average = average / MyArray.Length;
            return average;
        }












        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("a =");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b =");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c =");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Equation_solution(a, b, c));

            Console.WriteLine("Задание 2");
            int[] rndNumbers = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                rndNumbers[i] = rnd.Next();
                Console.Write("{0}", rndNumbers[i]);
            }
            Console.WriteLine("Введите 2 числа из данного массива, которые вы хотите поменять местами.");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < 20; i++)
            {
                if (rndNumbers[i] == Number1)
                {
                    temp1 = i;
                }
                if (rndNumbers[i] == Number2)
                {
                    temp2 = i;
                }
            }
            int Exchange = rndNumbers[temp1];
            rndNumbers[temp1] = rndNumbers[temp2];
            rndNumbers[temp2] = Exchange;
            for (int j = 0; j < 20; j++)
            {
                Console.Write("{0}", rndNumbers[j]);
            }

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите количество чисел в массиве:");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа, входящие в массив:");
            int[] Array_new = new int[Length];
            for (int i = 0; i < Array_new.Length; i++)
            {
                Array_new[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(Array_new);
            Console.WriteLine("После сортировки методом пузырька:");
            for (int i = 0; i < Array_new.Length; i++)
            {
                Console.WriteLine(Array_new[i]);
            }


            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите количество чисел в массиве:");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа, входящие в массив:");
            int[] massiv = new int[Length];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = Convert.ToInt32(Console.ReadLine());
            }
            double average;
            Task4_sum(massiv);

            Console.WriteLine("Задание 5"); //Проблема с созданием метода для рисования цифр и switch-case-default

            string[] images =
            {
                @"C:\Users\rubis\Desktop\Numbers\00.jpg",
                @"C:\Users\rubis\Desktop\Numbers\01.jpg",
                @"C:\Users\rubis\Desktop\Numbers\02.jpg",
                @"C:\Users\rubis\Desktop\Numbers\03.jpg",
                @"C:\Users\rubis\Desktop\Numbers\04.jpg",
                @"C:\Users\rubis\Desktop\Numbers\05.jpg",
                @"C:\Users\rubis\Desktop\Numbers\06.jpg",
                @"C:\Users\rubis\Desktop\Numbers\07.jpg",
                @"C:\Users\rubis\Desktop\Numbers\08.jpg",
                @"C:\Users\rubis\Desktop\Numbers\09.jpg",
                @"C:\Users\rubis\Desktop\Numbers\10.jpg",
            };
            try
            {
                Console.WriteLine("Введите число от 0 до 9");
                int num = Convert.ToInt32(Console.ReadLine());
                string path = images[num];
                Bitmap bitmap = new Bitmap(path);
                string result = "";
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        int pixelcolor = bitmap.GetPixel(x, y).R;
                        if (pixelcolor == 255)
                        {
                            result += "..";
                        }
                        else
                        {
                            result += "#";
                        }
                    }
                    result += "\n";
                }
                Console.WriteLine(result);
            }
            catch(Exception)
            {

            }
            finally
            {

            }









        }

    }
}

    
