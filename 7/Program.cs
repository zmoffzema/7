using System;

public class Program
{
    public static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Merged array: " + string.Join(", ", mergedArray));
    }

    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        if (array1 == null || array2 == null)
        {
            throw new ArgumentException("Input arrays cannot be null");
        }

        int[] result = new int[array1.Length + array2.Length];
        array1.CopyTo(result, 0);
        array2.CopyTo(result, array1.Length);

        return result;
    }
}