using System;
using System.Collections.Generic;

class MainClass
{
    static int FirstDuplicateNumber(int[] array)
    {
        List<int> numbersList = new List<int>();
        List<int> NumberCheck = new List<int>();

        foreach (int number in array) numbersList.Add(number);


        foreach (int item in numbersList)
        {
            if (NumberCheck.IndexOf(item) != -1) return item;
            NumberCheck.Add(item);
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] theArray = { 1, 3, 4, 9, 2, 3, 7, 9 };
        Console.WriteLine(FirstDuplicateNumber(theArray));
        Console.ReadLine();
    }
}