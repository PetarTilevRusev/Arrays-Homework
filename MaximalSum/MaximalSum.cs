using System;
using System.Collections.Generic;
using System.Linq;
                        /*Problem 8. Maximal sum
                        
                            Write a program that finds the sequence of maximal sum in given array.
                        
                        Example:
                        input 	                            result
                        2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4
                        
                            Can you do it with only one loop (with single scan through the elements of the array)?
                        */
class MaximalSum
{
    static void Main()
    {
        Console.Write("Array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        Random randomGenerator = new Random();

        Console.Write("Array values: ");
        for (int i = 0; i < arrayLength; i++)
        {
            //mixedArray[i] = randomGenerator.Next(-10, 10);
            //Console.Write("{0}, ", mixedArray[i]);

            array[i] = int.Parse(Console.ReadLine()); //If u wan't to manualy enter the array values!
        }

        int tempValue = 0;
        int biggestValue = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            
        }
    }
}

