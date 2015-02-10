using System;
                /*Problem 6. Maximal K sum
                
                    Write a program that reads two integer numbers N and K and an array of N elements from the console.
                    Find in the array those K elements that have maximal sum.
                */
class MaximalKSum
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());

        int[] nArray = new int[n];
        int result = 0;

        Random randomGenerator = new Random();
        for (int i = 0; i < nArray.Length; i++)
        {
            nArray[i] = randomGenerator.Next(k / 2, k * 2);
            Console.Write(nArray[i] + " ");
            if (nArray[i] == k)
            {
                result += k;
            }
        }

        Console.WriteLine("\nThe value of all K elements is: " + result);

    }
}

