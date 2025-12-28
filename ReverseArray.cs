using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class2
    {
      static void Main(string[] args)
      {
            Console.WriteLine("Please enter the size of the Array");
            int Size = int.Parse(Console.ReadLine());

            int[] MyArray = new int[Size];

            for (int i = 0; i < Size ; i++)
            {
                Console.WriteLine("Please Enter the Number");
                int Number = int.Parse(Console.ReadLine());

                MyArray[i] = Number;

            }
            int[]ReversedArray = MyArray.Reverse().ToArray();

            for (int i = 0;i < Size; i++)
            {
                Console.Write(ReversedArray[i] + " ");
            }

      }

    }
}
