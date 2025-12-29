using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Multi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Rows1 = 0;
            int Columns1 = 0;
            int Rows2 = 0;
            int Columns2 = 0;

            //Matrix 1
            Console.WriteLine("--- Matrix 1 Setup ---");
            Console.Write("Please Enter the number of Rows for 1st Matrix: ");
            Rows1 = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the number of Columns for 1st Matrix: ");
            Columns1 = int.Parse(Console.ReadLine());

            int[,] Matrix1 = new int[Rows1, Columns1];

            
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    Console.Write($"Please Enter the Value for the Cell [{i},{j}]: ");
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\n-------Your Matrix 1-------");
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    Console.Write(Matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Matrix 2
            bool num2 = true;
            while (num2 == true)
            {
                Console.WriteLine("\n--- Matrix 2 Setup ---");
                Console.Write("Please Enter the number of Rows for 2nd Matrix: ");
                Rows2 = int.Parse(Console.ReadLine());

                Console.Write("Please Enter the number of Columns for 2nd Matrix: ");
                Columns2 = int.Parse(Console.ReadLine());

                
                if (Rows2 != Rows1 || Columns2 != Columns1)
                {
                    Console.WriteLine($"Error! Matrix 2 must be the same size as Matrix 1 ({Rows1}x{Columns1})");
                    num2 = true;
                }
                else
                {
                    num2 = false;
                }
            }

            int[,] Matrix2 = new int[Rows2, Columns2];

            
            for (int i = 0; i < Rows2; i++)
            {
                for (int j = 0; j < Columns2; j++)
                {
                    Console.Write($"Please Enter the Value for the Cell [{i},{j}]: ");
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\n-------Your Matrix 2-------");
            for (int i = 0; i < Rows2; i++)
            {
                for (int j = 0; j < Columns2; j++)
                {
                    Console.Write(Matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int[,] Sum = new int[Rows1, Columns1];

            Console.WriteLine("\n------The Sum of the Matrices-----");

            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    Sum[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    Console.Write(Sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
