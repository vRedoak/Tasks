using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTask1
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if (!this.TriangleExistenceTest()) throw new Exception("Такого треугольника не может быть");
        }

        public double A
        {
            get
            { return a; }
            private set
            {
                if (value < 0) throw new Exception("Значение не может быть отрицательным");
                a = value;

            }
        }
        public double B
        {
            get
            { return b; }
            private set
            {
                if (value < 0) throw new Exception("Значение не может быть отрицательным");
                b = value;
            }
        }
        public double C
        {
            get
            { return c; }
            private set
            {
                if (value < 0) throw new Exception("Значение не может быть отрицательным");
                c = value;
            }
        }

        public bool TriangleExistenceTest() => (a + b > c && a + c > b && c + b > a);

        public double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public double Perimeter() => a + b + c;
    }
}
