using System;
using System.Collections.Generic;
using System.Linq;
                /*Problem 4. Maximal sequence
                
                    Write a program that finds the maximal sequence of equal elements in an array.
                
                        Example:
                        input 	                        result
                        2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2
                */
class MaximalSequence
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];


        Random randomGenerator = new Random(); //Generating random numbers, for filling our array elements
        for (int i = 0; i < arrayLength; i++) //For loop to fill every array element with random generated value
        {
            array[i] = randomGenerator.Next(1, 5);
        }

        int bestLength = 0, bestElement = 0;
        int currLength = 1, currElement = array[0];

        if (array.Length == 1)
        {
            bestElement = currElement;
            bestLength = 1;
            return;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == currElement)
            {
                currLength++;
            }
            else
            {
                currElement = array[i];
                currLength = 1;
            }

            if (currLength >= bestLength)
            {
                bestLength = currLength;
                bestElement = currElement;
            }
        }

        Console.Write("Array elements: " + "{" + string.Join(", ", array) + "}\n");
        Console.Write("The maximal sequence of equal elements in the array is: {");
        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(i != bestLength - 1 ? bestElement + ", " : bestElement + "}\n");
        }

    }
}

