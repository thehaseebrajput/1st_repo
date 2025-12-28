using System;

class Program
{
    static void Main()
    {
        // 1. Initialize the array
        int[] grades = { 85, 90, 78, 92, 88 };
        int sum = 0;

        // 2. Sum the elements
        foreach (int grade in grades)
        {
            sum += grade;
        }

        // 3. Calculate average
        double average = (double)sum / grades.Length;
        Console.WriteLine("The average grade is: " + average);
    }
}
