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
            bool num = true;

            while (num == true)
            {

                Console.Write("Please Enter the number of Rows for 1st Matrix: ");
                Rows1 = int.Parse(Console.ReadLine());

                Console.Write("Please Enter the number of Columns for 1st Matrix: ");
                Columns1 = int.Parse(Console.ReadLine());


                if (Rows1 != Columns1)
                {
                    Console.WriteLine("Error! Number of rows and columns must be equal");

                    num = true;
                }
                else
                {
                    num = false;
                }
            }



            int[,] Matrix1 = new int[Rows1, Columns1];

            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {

                    Console.Write($"Please Enter the Value for the Cell [{i},{j}]:");
                    Matrix1[i, j] = int.Parse(Console.ReadLine());


                }

            }

            Console.WriteLine("-------Your Matrix 1-------");

            for (int i = 0; i < Columns1; i++)
            {
                for (int j = 0; j < Rows1; j++)
                {
                    Console.Write(Matrix1[i, j] + " ");

                }
                Console.WriteLine();
            }




            bool num2 = true;
            while (num2 == true)
            {
                Console.Write("Please Entert the number of Rows for 2nd Matrix: ");

                Rows2 = int.Parse(Console.ReadLine());


                Console.Write("Please enter the number of Columns foe 2nd Matrix: ");
                Columns2 = int.Parse(Console.ReadLine());

                if (Rows2 != Columns2)
                {
                    Console.WriteLine("Error! Number of rows and columns must be equal");

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

                    Console.Write($"Please Enter the Value for the Cell [{i},{j}]:");
                    Matrix2[i, j] = int.Parse(Console.ReadLine());


                }

            }

            Console.WriteLine("-------Your Matrix 2-------");

            for (int i = 0; i < Columns2; i++)
            {
                for (int j = 0; j < Rows2; j++)
                {
                    Console.Write(Matrix2[i, j] + " ");

                }
                Console.WriteLine();
            }




            int[,] Sum = new int[Rows2, Columns2];

            Console.WriteLine("------The sum of the matrices-----");

            for (int i = 0; i < Rows2; i++)
            {
                for (int j = 0; j < Columns2; j++)
                {
                    Sum[i, j] = Matrix1[i, j] + Matrix2[i, j];
         
                    Console.Write(Sum[i, j] + " ");

                }

                Console.WriteLine();
            }
        } 
    }
}
