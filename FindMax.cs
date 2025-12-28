using System;

class Program
{
    static void Main()
    {
        // 1. Initialize the array
        int[] numbers = { 10, 50, 24, 78, 5 };
        int max = numbers[0];

        // 2. Loop through to find the max
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("The maximum value is: " + max);
    }
}

