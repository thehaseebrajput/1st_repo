using System;

class Program
{
    static void Main()
    {
        // 1. Initialize the array
        int[] original = { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original Array:");
        foreach(int num in original) Console.Write(num + " ");
        
        // 2. Reverse the array
        Array.Reverse(original);

        Console.WriteLine("\nReversed Array:");
        foreach(int num in original) Console.Write(num + " ");
    }
}
