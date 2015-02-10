using System;
                /*Problem 3. Compare char arrays
                
                    Write a program that compares two char arrays lexicographically (letter by letter).
                */
class CharArrayCompare
{
    static void Main()
    {
        Console.WriteLine("We are about to compare two arrays! But this time letter by letter\nGet ready!");
        Console.Write("Length the arrays: ");
        int arrayLength = int.Parse(Console.ReadLine());

        char[] arrayOne = new char[arrayLength];
        char[] arrayTwo = new char[arrayLength];
        int arrayCount = 1;

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("First array character {0} = ", arrayCount);
            arrayOne[i] = char.Parse(Console.ReadLine());

            Console.Write("Second array character {0} = ", arrayCount);
            arrayTwo[i] = char.Parse(Console.ReadLine());
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

