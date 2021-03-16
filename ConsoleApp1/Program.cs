using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здраствуйте! Для создания треугольника вам необходимо ввести три его стороны.");
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("C = ");
                double c = double.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine("Площадь треугольник: "+ triangle.Square());
                Console.WriteLine("Периметр треугольника: " + triangle.Perimeter());
            }
            catch (Exception e) { Console.WriteLine("Ошибка: " + e.Message); }
            Console.ReadLine();
        }
    }
}
