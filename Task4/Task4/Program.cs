using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Matrix m = new Matrix
               (
                   new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }
               );
                Matrix m2 = m + m;
                for (int i = 0; i < m.Value.GetLength(0); i++)
                {
                    for (int j = 0; j < m.Value.GetLength(1); j++)
                    {
                        Console.Write(m2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            Console.ReadLine();

        }
    }
}
