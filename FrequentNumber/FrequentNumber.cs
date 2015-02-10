using System;
                /*Problem 9. Frequent number
                
                    Write a program that finds the most frequent number in an array.
                
                                Example:
                                input 	                                    result
                                4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	    4 (5 times)
                */
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];


        Random randomGenerator = new Random();

        Console.Write("Array values: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = randomGenerator.Next(1, 10);
            Console.Write("{0} ", array[i]);
        }

        int count = 1;
        int currentIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == array[currentIndex])
            {
                count++;
            }

            //else
            //{
            //    count--;
            //}

            if (count == 0)
            {
                currentIndex = i;
            }
        }

        Console.WriteLine("\n{0} ({1} times)", array[currentIndex], count);
    }
}

