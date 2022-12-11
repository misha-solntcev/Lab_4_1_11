using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 11. Задан массив положительных вещественных чисел. 
    Вычислить значения функции у=0,5х при значениях аргумента, 
    заданных в исходном массиве, и поместить их в другой массив. 
    Вывести на экран дисплея оба массива в виде двух столбцов. */

namespace Lab_4_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)            
                array[i] = random.Next(-10, 10);

            double[] array_Fx = new double[array.Length];
            for (int i = 0; i < array_Fx.Length; i++)
                array_Fx[i] = array[i] * 0.5;

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + "\t" + array_Fx[i]);
            Console.WriteLine();

            // Linq
            var res = array.Select(x => 0.5 * x).ToArray();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + "\t" + res[i]);

            Console.ReadKey();
        }
    }
}
