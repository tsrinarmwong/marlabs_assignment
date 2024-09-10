// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 9, 3, 9, 3, 9, 7, 9 };
        Console.WriteLine("Unpaired element in Assignment 1: " + new Assignment1().solution(array1));

        // Test Case 1: array1a - Valid unpaired element scenario
        int[] array1a = { 5, 1, 5, 2, 2 };
        Console.WriteLine("Unpaired element in array1a: " + new Assignment1().solution(array1a));  // Expected output: 1

        // Test Case 2: array1b - Valid unpaired element scenario
        int[] array1b = { 1000000000, 7, 7, 3, 3 };
        Console.WriteLine("Unpaired element in array1b: " + new Assignment1().solution(array1b));  // Expected output: 1000000000

        // Test Case 3: array1c - Valid unpaired element scenario
        int[] array1c = { 13, 6, 8, 13, 8, 9, 6 };
        Console.WriteLine("Unpaired element in array1c: " + new Assignment1().solution(array1c));  // Expected output: 9

        // Test Case 4: array1d - All elements have pairs
        int[] array1d = { 4, 4, 5, 5, 6, 6};
        Console.WriteLine("Unpaired element in array1d: " + new Assignment1().solution(array1d));  // Expected output: 0

        int[] array2 = { 3, 2, -6, 4, 0 };
        Console.WriteLine("Maximum sum of any slice in Assignment 2: " + new Assignment2().solution(array2));

        // Test Case 1: array2a - Using negative value
        int[] array2a = { -2, -3, -1, -4 };
        Console.WriteLine("Maximum sum of any slice in array2a: " + new Assignment2().solution(array2a));  // Expected output: 5

        // Test Case 2: array2b - Only one element in the array
        int[] array2b = { 5 };
        Console.WriteLine("Maximum sum of any slice in array2b: " + new Assignment2().solution(array2b));  // Expected output: -1

        // Test Case 3: array2c - Simple positive number
        int[] array2c = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Maximum sum of any slice in array2c: " + new Assignment2().solution(array2c));  // Expected output: 5

        // Test Case 4: array2d - Alternating positives and negatives
        int[] array2d = { 5, -1, 5, -1, 5 };
        Console.WriteLine("Maximum sum of any slice in array2d: " + new Assignment2().solution(array2d));  // Expected output: 15
    }
}

class Assignment1
{
    public int solution(int[] A)
    {
        int unpaired = 0; // default value when couldn't find
        foreach (int number in A)
        {
            unpaired ^= number; // XOR all number
        }
        return unpaired;
    }
}

class Assignment2
{
    public int solution(int[] A)
    {
        int maxEndingHere = A[0]; // default value when couldn't find
        int maxSofar = A[0];

        for (int i =1; i < A.Length; i++)
        {
            maxEndingHere = Math.Max(A[i], maxEndingHere + A[i]);
            maxSofar = Math.Max(maxSofar, maxEndingHere);
        }

        return maxSofar;
    }
}