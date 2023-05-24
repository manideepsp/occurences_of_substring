using System;
using System.Collections.Generic;
using System.Globalization;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("enter the string");
        string originalString = Console.ReadLine();
        //Console.WriteLine(originalString);

        Console.WriteLine("enter the substring");
        string subString = Console.ReadLine();
        //Console.WriteLine(subString);

        List<int> listOfOccurredIndexes = new List<int>();

        for (int i = 0; i < originalString.Length - subString.Length; i++)
        {
            int flag = 0;
            if (originalString[i] == subString[0])
            {
                int tempIndex = i;
                for (int j = 0; j < subString.Length; j++)
                {
                    if (originalString[i+j] != subString[j])
                    {
                        i = tempIndex;
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    listOfOccurredIndexes.Add(tempIndex);
                }
            }
        }
        for (int i = 0; i < listOfOccurredIndexes.Count; i++)
        {
            Console.WriteLine(listOfOccurredIndexes[i]);
        }
        Console.ReadKey();
    }
}