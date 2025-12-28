using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
      static void Main(string[] args)
      {
           Console.WriteLine("Please Enter the Number of Students");
            int Size = int.Parse(Console.ReadLine());
            int[] Students = new int[Size];
            for (int i = 0; i < Size; i++) 
            {
                Console.WriteLine("Please Enter the Marks of student");
                int Marks = int.Parse(Console.ReadLine());
                Students[i] = Marks;


            }
            int BestScore = Students[0];

            for (int i = 0; i < Students.Length; i++)
            {

                if (Students[i] > BestScore)
                {
                    BestScore = Students[i];
                }
            }

            for (int i = 0; i < Students.Length; i++)
            { 
                if (Students[i] >= BestScore - 10)
                {
                    Console.WriteLine("Student " + i + " Got A Grade");

                }

                else if (Students[i] >= BestScore - 20 )
                {
                    Console.WriteLine("Student " + i + " Got B Grade");
                }

                else if (Students[i] >= BestScore - 30)
                {
                    Console.WriteLine("Student " + i + " Got C Grade");
                }

                else if (Students[i] >= BestScore - 40)
                {
                    Console.WriteLine("Student " + i + " Got D Grade");
                }

                else { Console.WriteLine("Student " + i + " Got F Grade"); }  

            }          
            
        }
    }
}
