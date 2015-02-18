using System;
using System.Collections.Generic;
using System.Linq;
                    /*Problem 7. Selection sort
                    
                        Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
                        Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
                    */
class SelectionSort
{
    static void Main()
    {
        Console.Write("Array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] mixedArray = new int[arrayLength];

        Random randomGenerator = new Random();

        Console.Write("Array values: ");
        for (int i = 0; i < arrayLength; i++)
        {
            mixedArray[i] = randomGenerator.Next(1, 10);
            Console.Write("{0}, ", mixedArray[i]);

            //mixedArray[i] = int.Parse(Console.ReadLine()); //If u wan't to manualy enter the array values!
        }

        //Sorting
        for (int i = 1; i < arrayLength; i++)
        {
            for (int j = 0; j < arrayLength; j++)
            {
                if (mixedArray[i] <= mixedArray[j])
                {
                    int tempValue = mixedArray[i];
                    mixedArray[i] = mixedArray[j];
                    mixedArray[j] = tempValue;
                }
            }

        }
        Console.WriteLine();

        //Printing
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Array[{0}] = {1}", i, mixedArray[i]);
        }
    }
}

