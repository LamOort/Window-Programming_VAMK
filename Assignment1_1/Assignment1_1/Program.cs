using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(10);
            int[,] matrix1 = new int[x, x];
            int[,] matrix2 = new int[x, x];
            int[,] Multi = new int[x, x];

            Console.WriteLine("Matrix 1 is: ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(20);
                    Console.Write("{0,7}", matrix1[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix 2 is: ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(20);
                    Console.Write("{0,7}", matrix2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of 2 matrices is:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    int elementSum = matrix1[i, j] + matrix2[i, j];
                    Console.Write(elementSum + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Subtraction of 2 matrices is:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    int elementSub = matrix1[i, j] - matrix2[i, j];
                    Console.Write(elementSub + "    ");
                }
                Console.WriteLine();
            }
            

            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    Multi[i, j] = 0;



            for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                    Multi[i, j] = 0;
                        for(int k=0; k < matrix1.GetLength(1); k++)
                        {
                        Multi[i, j] += matrix1[i, k] * matrix2[k, j];
                        
                        }
                    }
                }
            Console.WriteLine("Multiplication of 2 matrices is: \n");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write("{0}\t", Multi[i,j]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
            return;
        }
    }
}
