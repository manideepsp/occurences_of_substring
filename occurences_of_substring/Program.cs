using System;
using System.Collections.Generic;
using System.Linq;

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

        int index = 0;
        foreach( char iterator in originalString)
        {
            foreach( char iterator2 in subString)
            {
                if( iterator2 != iterator)
                {
                    index++;
                    continue;
                }

                listOfOccurredIndexes.Append(index);
                
                index++;
            }
        }
       foreach( char iterator in listOfOccurredIndexes)
        {
            Console.WriteLine(iterator);
        }
        Console.ReadKey();
    }
}