using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EpamTask1
{
    public class Triangle
    {
        private double[] _sides;

        public Triangle(double a, double b, double c)
        {
            _sides = new double[3] { a, b, c };
            if (_sides.Any(i => i <= 0))
                throw new ArgumentException("Значения должны быть положительными");
            if (!this.TriangleExistenceTest())
                throw new ArgumentException("Такого треугольника не может быть");
        }

        public double GetSideByIndex(int index)
        {
            if (index < _sides.Length && index >= 0)
                return _sides[index];
            else throw new ArgumentOutOfRangeException("Недопустимый индекс");
        }

        public bool TriangleExistenceTest()
        {
            double sum = Perimeter();
          return  _sides.All(i => sum - i > i);
        }

        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * _sides.Select(i => p - i).Aggregate((x, y) => x * y));
        }

        public double Perimeter() => _sides.Sum();
    }
}
