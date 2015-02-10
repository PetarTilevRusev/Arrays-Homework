using System;
                /*Problem 5. Maximal increasing sequence
                
                    Write a program that finds the maximal increasing sequence in an array.
                
                            Example:
                            input 	                result
                            3, 2, 3, 4, 2, 2, 4 	2, 3, 4
                */
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];


        Random randomGenerator = new Random(); //Generating random numbers, for filling our array elements

        Console.Write("Array values: ");
        for (int i = 0; i < arrayLength; i++) //For loop to fill every array element with random generated value
        {
            array[i] = randomGenerator.Next(1, 5);
            Console.Write("{0} ", array[i]);
        }

        int bestLength = 0, bestElement = 0;
        int currLength = 1, currElement = array[1];

        if (array.Length == 1)
        {
            bestElement = currElement;
            bestLength = 1;
            return;
        }

        for (int i = 0; i < arrayLength - 1; i++)
        {
            if (array[i] < array[i + 1] && array[i + 1] == array[i] + 1) //Check if the current element is equal to next array element
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
        Console.WriteLine();

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(i != bestLength - 1 ? bestElement + ", " : bestElement + "\n");
        }
    }
}

