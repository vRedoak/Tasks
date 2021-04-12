using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task4
{
    public class Matrix
    {
        public double this[int i, int j]
        {
            get
            {
                return Value[i, j];
            }
            set
            {
                Value[i, j] = value;
            }
        }

        public double[,] Value { get; set; }

        public Matrix(int i, int j)
        {
            Value = new double[i, j];
        }

        public Matrix(double[,] matrix)
        {
            Value = matrix;

        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (!CheckSize(matrix1, matrix2))
                throw new Exception("Матрицы разной длинны");
            double[,] matrixResult = new double[matrix1.Value.GetLength(0), matrix1.Value.GetLength(1)];
            for (int i = 0; i < matrix1.Value.GetLength(0); i++)
                for (int j = 0; j < matrix1.Value.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            return new Matrix(matrixResult);
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (!CheckSize(matrix1, matrix2))
                throw new Exception("Матрицы разной длинны");
            double[,] matrixResult = new double[matrix1.Value.GetLength(0), matrix1.Value.GetLength(1)];
            for (int i = 0; i < matrix1.Value.GetLength(0); i++)
                for (int j = 0; j < matrix1.Value.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            return new Matrix(matrixResult);
        }

        private static bool CheckSize(Matrix m1, Matrix m2)
        {
            return (m1.Value.GetLength(0) == m2.Value.GetLength(0)) && (m1.Value.GetLength(1) == m2.Value.GetLength(1));
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Value.GetLength(1) != matrix2.Value.GetLength(0))
                throw new Exception("Не соответствие размеров матриц");
            double[,] matrixResult = new double[matrix1.Value.GetLength(0), matrix1.Value.GetLength(1)];
            for (int i = 0; i < matrix1.Value.GetLength(0); i++)
                for (int j = 0; j < matrix2.Value.GetLength(1); j++)
                    for (int k = 0; k < matrix2.Value.GetLength(0); k++)
                    {
                        matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
            return new Matrix(matrixResult);
        }


        public static Matrix operator *(Matrix matrix1, double x)
        {
            int i, j;

            for (i = 0; i < matrix1.Value.GetLength(0); i++)
            {
                for (j = 0; j < matrix1.Value.GetLength(1); j++)
                {
                    matrix1.Value[i, j] = x * matrix1.Value[i, j];
                }
            }
            return matrix1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Matrix m = obj as Matrix;
            if (!(obj is Matrix))
                return false;
            if (!CheckSize(this, m))
                return false;
            for (int i = 0; i < this.Value.GetLength(0); i++)
                for (int j = 0; j < this.Value.GetLength(1); j++)
                    if (this[i, j] != m[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hashcode = this[0, 0].GetHashCode();
            hashcode = hashcode + this[0, 1].GetHashCode();
            hashcode = hashcode + this[0, 2].GetHashCode();
            return hashcode;
        }
    }
}
