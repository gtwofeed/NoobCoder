using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobCoder
{
    internal class Matrix
    {
        int n;
        internal int N 
        { 
            get { return n; }
            set { n = value; }
        }
        int m;
        internal int M
        {
            get { return m; }
            set { m = value; }
        }
        double[,] data;
        internal double[,] Data
        {
            get { return data; }
            set { data = value; }
        }
        internal void Read()
        {
            int[] intInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            N = intInput[0];
            M = intInput[1];
            Data = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                double[] input = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                for (int j = 0; j < M; j++)
                {
                    Data[i, j] = input[j];
                }
            }
        }
        internal void Write()
        {
            for (int i = 0; i < N; i++)
            {
                bool chek = true;
                for (int j = 0; j < M; j++)
                {
                    Console.Write(chek ? Data[i, j] : " " + Data[i, j]);
                    chek = false;
                }
                Console.WriteLine();
            }
        }
        internal void Multiply(double n)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Data[i, j] *= n;
                }
            }
        }
        internal void Sum(Matrix A)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Data[i, j] += A.Data[i, j];
                }
            }
        }
        internal static Matrix Multiplication(Matrix A, Matrix B)
        {
            Matrix M = new Matrix();
            M.N = A.N;
            M.M = B.M;
            M.Data = new double[M.N, M.M];
            for (int x = 0; x < A.N; x++)
            {
                for (int y = 0; y < B.M; y++)
                {
                    for (int z = 0; z < A.M; z++)
                    {
                        M.Data[x, y] += A.Data[x, z] * B.Data[z, y];
                    }
                }
            }
            return M;
        }
    }
}
