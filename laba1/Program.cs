using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Console.WriteLine("Введите количество строк: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            m = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[n, m];
            Random r = new Random();
            Console.WriteLine("Массив:"); //создание массива
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = r.Next(-10, 10);

                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            double max = array[0, 0];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    if (Math.Abs(array[i, j]) > max)
                    {
                        max = Math.Abs(array[i, j]);
                    }
                }
            }
            Console.WriteLine(Convert.ToDouble(max));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = array[i, j] / max;
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

