using System;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Input amount of the first array:");
        int amountFirstArray = Convert.ToInt32(ReadLine());
        WriteLine("Input amount of the second array:");
        int amountSecondArray = Convert.ToInt32(ReadLine());
        int[,] array = new int[amountFirstArray, amountSecondArray];

        int lengthFirstArray = array.GetLength(0); // get length of the row
        int lengthSecondArray = array.GetLength(1); // get length of the column

        WriteLine($"Length of the first array: {lengthFirstArray}");
        WriteLine($"Length of the second array: {lengthSecondArray}");

        float totalFirstGroup = 0.0f;
        float totalSecondGroup = 0.0f;

        WriteLine("Input data in the array:");
        for(int firstIndex = 0; firstIndex < lengthFirstArray; firstIndex++)
        {
            for(int secondIndex = 0;  secondIndex < lengthSecondArray; secondIndex++)
            {
                array[firstIndex, secondIndex] = Convert.ToInt32(ReadLine());
            }
        }
        
        for(int index = 0; index < lengthSecondArray; index++)
        {
            totalFirstGroup += array[0, index];
        }

        for(int index = 0; index < lengthSecondArray; index++)
        {
            totalSecondGroup += array[1, index];
        }

        WriteLine($"total first group: {totalFirstGroup / lengthSecondArray}");
        WriteLine($"total second group: {totalSecondGroup / lengthSecondArray}");

        ReadLine();
    }
}