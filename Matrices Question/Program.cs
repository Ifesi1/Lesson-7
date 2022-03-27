using System;

namespace Matrices_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] matrixC = new int[3,3];
            int det = 1;
            
            Console.Write("Please enter the numbers for matrix A:  ");
            for (int a = 0; a < matrixA.GetLength(0); a++)
            {
                for (int b = 0; b < matrixA.GetLength(1); b++)
                {
                    Console.Write("[{0},{1}]", a,b);
                    matrixA[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Please enter the numbers for Matrix B: ");
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    matrixB[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Matrix A is: ");
            for (int a = 0; a < 3; a++)
            {
                Console.Write("\n");
                for (int b = 0; b < 3; b++)
                {
                    Console.Write("\t" , matrixA[a,b]);
                }
            }

            Console.Write("Matrix B is: ");
            for (int a = 0; a < 3; a++)
            {
                Console.Write("\n");
                for (int b = 0; b < 3; b++)
                {
                    Console.Write("\t"+matrixB[a,b]);
                }
            }

            Console.Write("The sum of Matrix A and Matrix B are:  ");
            for (int a = 0; a < 3; a++)
            {
                Console.Write("\n");
                for (int b = 0; b < 3; b++)
                {
                    matrixC[a,b] = matrixA[a,b] + matrixB[a,b];
                    Console.Write("\t"+matrixC[a,b]);
                }
            }

            Console.WriteLine("The product of matrix A and matrix B is:  ");
            for (int a = 0; a < 3; a++)
            {
                Console.Write(" ");
                for (int b = 0; b < 3; b++)
                {
                    matrixC[a,b] = matrixA[a,b] * matrixB[a,b];
                    Console.WriteLine("\t"+ matrixC[a,b]);
                }
            }

            Console.WriteLine("The difference of matrix A and matrix B is:  ");
            for (int a = 0; a < 3; a++)
            {
                Console.Write(" ");
                for (int b = 0; b < 3; b++)
                {
                    matrixC[a, b] = matrixA[a, b] - matrixB[a, b];
                    Console.WriteLine("\t" + matrixC[a, b]);
                }
            }

            Console.WriteLine("The determinant of matrix A is:  ");
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    det= matrixA[0,0]*((matrixA[1,1]*matrixA[2,2])+(matrixA[1,2]*matrixA[2,1])) -
                        matrixA[0,1]*((matrixA[1,0]*matrixA[2,2])+(matrixA[1,2]*matrixA[2,0])) +
                        matrixA[0,2]*((matrixA[1,0]*matrixA[2,1])+(matrixA[1,1]*matrixA[2,0]));    
                }
                Console.WriteLine("\t"+det);
            }

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (matrixA[a,b] > matrixB[a,b])
                    {
                        Console.WriteLine("The largest matrix is: {0}",matrixA);
                    }
                    else
                    {
                        Console.WriteLine("The largest matrix is: "+matrixB);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
