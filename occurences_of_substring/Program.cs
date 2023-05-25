using occurences_of_substring;
using System;

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

        #region objects
        Validation validate = new Validation();
        Occurences list = new Occurences();
        PrintOutput display = new PrintOutput();
        #endregion

        if(validate.EdgeCases(originalString, subString)) display.ErrorMessage();

        display.OutPut(list.LIstOfOccurences(originalString, subString));

        Console.ReadKey();
    }
}