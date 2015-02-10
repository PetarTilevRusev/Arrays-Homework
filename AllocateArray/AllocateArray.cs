using System;
                /*Problem 1. Allocate array
                
                    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
                    Print the obtained array on the console.
                */
class AllocateArray
{
    static void Main()
    {
        int[] integers = new int[20];
        int result = 0;
        int multiplier = 5;

        for (int i = 0; i < 20; i++)
        {
            integers[i] = i;
            
            result = integers[i] * multiplier;
            
            Console.WriteLine("{0} * {1} = {2}", integers[i], multiplier, result);
        }

        //The code below is my first solution, but after I read the task again. I realized that my code is not actualy currect! But I'll leave it, becouse I may be wrog!

        //Random randomInteger = new Random();
        //for (int i = 0; i < 20; i++)
		//{
        //    integers[i] = randomInteger.Next(100);
        //
        //    result = integers[i] * 5;
        //
        //    Console.WriteLine("{0} * 5 = {1}", integers[i], result);
		//}
    }
}

