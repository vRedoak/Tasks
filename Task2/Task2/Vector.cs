using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Vector
    {
        double[] _point;

        public Vector(double[] point)
        {
            if (point.Length>3 || point.Length<3)
                throw new Exception("В массиве точек должно быть три значения!");
            _point = point;
        }

        public Vector(double x, double y, double z)
        {
            _point = new double[3] { x, y, z };
        }

        public double[] Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value.Length > 3 || value.Length < 3)
                    throw new Exception("В массиве точек должно быть три значения!");
                _point = value;
            }
        }

        public static bool operator ==(Vector a, Vector b)
        {
            return a._point.SequenceEqual(b._point);
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return !a._point.SequenceEqual(b._point);
        }

        public static Vector operator *(Vector a, double x)
        {
            return new Vector(a._point.Select(i => i * x).ToArray<double>());
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a._point.Select((value, index) => value + b._point[index]).ToArray<double>());
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a._point.Select((value, index) => value - b._point[index]).ToArray<double>());
        }

        public double ScalarMultiplication(Vector a)
        {
            return _point.Select((i, index) => i * a._point[index]).Aggregate((x, y) => x + y);
        }

        public Vector VectorMultiplication(Vector a)
        {
            return new Vector(_point[1] * a._point[2] - _point[2] * a._point[1], - (_point[0] * a._point[2] - _point[2] * a._point[0]),  (_point[0] * a._point[1] - _point[1] * a._point[0]));
        }

        public double Module()
        {
            return Math.Sqrt(_point.Select(i=>i*i).Aggregate((x,y) => x+y ));
        }

        public Vector Normalization()
        {
            return new Vector(_point.Select(i => i / Module()).ToArray<double>());
        }

        public override string ToString()
        {
            return $"x= {_point[0]}, y= {_point[1]}, z= {_point[2]}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Vector v = obj as Vector;
            if (!(obj is Vector))
               return false;
            return _point[0] == v._point[0] && _point[1] == v._point[1] && _point[2] == v._point[2];

        }

        public override int GetHashCode()
        {
            int hashcode = _point[0].GetHashCode();
            hashcode = hashcode + _point[1].GetHashCode();
            hashcode = hashcode + _point[2].GetHashCode();
            return hashcode;
        }
    }
}
