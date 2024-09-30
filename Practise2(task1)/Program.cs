using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array_num = new int[n];
            for (int i = 0; i < n; i++) array_num[i] = i + 1;
            
            for (int j = n-1; j >= 0; j--)
            {
                Console.WriteLine(Convert.ToString(array_num[j]));
            }
            

            int matrix_size = Convert.ToInt32(Console.ReadLine());
            int[,] squareArray = new int[matrix_size, matrix_size];
            for (int i = 0; i < matrix_size; i++)
                for (int j = 0; j < matrix_size; j++)
                    squareArray[i, j] = (i - 1 <= j) ? 1 : 0;

            for (int i = 0; i < matrix_size; i++)
            {
                for (int j = 0; j < matrix_size; j++)
                    Console.Write(squareArray[i, j] + " ");
                Console.WriteLine();
            }

            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[M, N];
            int value = 1;

            int top = 0, bottom = M - 1, left = 0, right = N - 1;
            while (value <= M * N)
            {
                for (int i = left; i <= right; i++)
                {
                    array[top, i] = value++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    array[i, right] = value++;
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        array[bottom, i] = value++;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        array[i, left] = value++;
                    }
                    left++;
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
