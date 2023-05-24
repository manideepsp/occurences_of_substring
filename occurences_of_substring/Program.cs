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

        Class1 obj = new Class1();
        Console.WriteLine(obj.Method(originalString, subString));
        Console.ReadKey();
    }
}