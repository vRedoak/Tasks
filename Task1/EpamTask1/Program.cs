using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здраствуйте! Для создания треугольника вам необходимо ввести три его стороны!");
                Console.Write("A = ");
                CheckData(out double a);
                Console.Write("B = ");
                CheckData(out double b);
                Console.Write("C = ");
                CheckData(out double c);
                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine("Площадь треугольник: " + Math.Round( triangle.Square(),2));
                Console.WriteLine("Периметр треугольника: " + triangle.Perimeter());
            }
            catch (Exception e) { Console.WriteLine("Ошибка: " + e.Message); }
            Console.ReadLine();
        }

        private static void CheckData(out double number)
        {
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Вы ввели недопустимые данные. Попробуйте еще раз");
            }
        }
    }
}
