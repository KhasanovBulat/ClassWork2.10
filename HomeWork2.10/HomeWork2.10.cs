using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._10
{
    class Program
    {
        static int[] QuickSort(int[] Array, int maxIndex, int minIndex)
        {
            if (minIndex >= maxIndex)
            {
                return Array;
            }
            int Pivot = 0;
            QuickSort(Array, minIndex, Pivot - 1);
            QuickSort(Array, Pivot + 1, maxIndex);
            return Array;
        }

        static void ChangePosition(ref int LeftOne, ref int RightOne)
        {
            int temp = LeftOne;
            LeftOne = RightOne;
            RightOne = temp;
        }

        static int ChooseThePivot(int[] Array, int maxIndex, int minIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++) 
            {
                if (Array[i] < Array[maxIndex])
                {
                    pivot++;
                    ChangePosition(ref Array[pivot], ref Array[i]);
                }
            }
            return pivot;
            ChangePosition(ref Array[pivot], ref Array[maxIndex]);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите количество чисел в массиве:");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа, входящие в массив:");
            int[] UnsortedArray = new int[Length];

            for (int i = 0; i < UnsortedArray.Length; i++)
            {
                UnsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] SotredArray = QuickSort(UnsortedArray,0,UnsortedArray.Length-1);
            Console.WriteLine($"После быстрой сортировки: {0}", SotredArray);
        }
    }
}
