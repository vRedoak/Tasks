using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здраствуйте, введите данные первого вектора");
                Vector vector = new Vector(CheckData(out double x), CheckData(out double y), CheckData(out double z));
                Console.WriteLine("Введите данные второго вектора");
                Vector vector1 = new Vector(CheckData(out double x1), CheckData(out double y1), CheckData(out double z1));
                Console.WriteLine("Введите число для расчетов");
                double i = CheckData(out i);

                Console.WriteLine("Нормлизация первого вектора: " + vector.Normalization());
                Console.WriteLine("Модуль первого вектора: " + Math.Round(vector.Module()));
                Console.WriteLine("Умножение первого вектора на число: " + vector * i);

                Console.WriteLine("Нормлизация второго вектора: " + vector1.Normalization());
                Console.WriteLine("Модуль второго вектора: " + vector1.Module());
                Console.WriteLine("Умножение второго вектора на число: " + vector1 * i);

                Console.WriteLine("Результат сравнения: " + (vector == vector1));
                Console.WriteLine("Сложение векторов: " + (vector + vector1));
                Console.WriteLine("Вычитание векторов: " + (vector - vector1));
                Console.WriteLine("Скалярное умножение: " + vector.ScalarMultiplication(vector1));
                Console.WriteLine("Векторное умножение: " + vector.VectorMultiplication(vector1));
                Console.WriteLine(vector.GetHashCode() + " - " + vector1.GetHashCode());
                vector.Equals(vector1);
                Console.ReadLine();
            }
            catch(Exception e) { Console.WriteLine("Ошибка:" + e.Message); Console.ReadLine(); }
        }

        private static double CheckData(out double number)
        {
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Вы ввели недопустимые данные. Попробуйте еще раз");
            }
            return number;
        }
    }
}
