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

        Console.WriteLine("Array values: ");
        for (int i = 0; i < arrayLength; i++) //For loop to fill every array element with random generated value
        {
            array[i] = randomGenerator.Next(1, 10);
            Console.Write("{0} ", array[i]);

            //array[i] = int.Parse(Console.ReadLine()); //If u wan't to manualy enter the array values!
        }

        int previousElement = array[0];
        int currentLength = 1;
        int bestLength = 0;
        int currentValue = 0;
        int bestValue = 0;

        Console.WriteLine();

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > previousElement)
            {
                if (array[i] - 1 == previousElement)
                {
                    currentLength++;
                    currentValue = array[i];
                }
            }
            else
            {
                currentLength = 1;
            }

            if (currentLength >= bestLength)
            {
                bestLength = currentLength;
                bestValue = currentValue;
            }

            previousElement = array[i];
        }
        
        int countStart = (bestValue - bestLength) + 1;

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(countStart + ", ");
            countStart++;
        }

        Console.WriteLine();
    }
}

