using System;
                /*Problem 2. Compare arrays
                
                    Write a program that reads two integer arrays from the console and compares them element by element.
                */
class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("We are about to compare two arrays!\nGet ready!");
        Console.Write("Length the arrays: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[arrayLength];
        int[] arrayTwo = new int[arrayLength];
        int arrayCount = 1;

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("First array number {0} = ", arrayCount);
            arrayOne[i] = int.Parse(Console.ReadLine());

            Console.Write("Second array number {0} = ", arrayCount);
            arrayTwo[i] = int.Parse(Console.ReadLine());
            arrayCount++;
        }

        Console.Clear();

        for (int i = 0; i < arrayLength; i++)
        {
            if (arrayOne[i] > arrayTwo[i])
            {
                Console.WriteLine("{0} > {1}", arrayOne[i], arrayTwo[i]);
            }
            else if (arrayOne[i] < arrayTwo[i])
            {
                Console.WriteLine("{0} < {1}", arrayOne[i], arrayTwo[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", arrayOne[i], arrayTwo[i]);
            }
        }
    }
}

