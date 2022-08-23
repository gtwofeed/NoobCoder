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
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            N = input[0];
            M = input[1];
            Data = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
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

        }
    }
}
