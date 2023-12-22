using System;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Input amount in the array:");
        int amountFirstArray = Convert.ToInt32(ReadLine());
        WriteLine("Input amount in the array:");
        int amountSecondArray = Convert.ToInt32(ReadLine());

        float totalFirstGroup = 0.0f;
        float totalSecondGroup = 0.0f;

        int[,] array = new int[amountFirstArray, amountSecondArray];

        int lengthFirstArray = array.GetLength(0); // length of the fisrt array
        int lengthSecondArray = array.GetLength(1); // length of the second array

        WriteLine("Input data in the array:");
        for(int firstIndex = 0; firstIndex < lengthFirstArray; firstIndex++)
        {
            for(int secondIndex = 0; secondIndex < lengthSecondArray; secondIndex++)
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
        
        WriteLine($"First Group: {totalFirstGroup / lengthSecondArray}");
        WriteLine($"First Group: {totalSecondGroup / lengthSecondArray}");

        ReadLine();
    }
}