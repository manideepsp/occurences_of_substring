using System;
using System.Collections.Generic;


namespace occurences_of_substring
{
    public class Class1
    {
        public List<int> Method(string originalString, string subString)
        {
            List<int> listOfOccurredIndexes = new List<int>();

            for (int i = 0; i < originalString.Length - subString.Length; i++)
            {
                bool flag = true;
                if (originalString[i] == subString[0])
                {
                    for (int j = 0; j < subString.Length; j++)
                    {
                        if (originalString[i + j] != subString[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        listOfOccurredIndexes.Add(i);
                    }
                }
            }
            
            for (int i = 0; i < listOfOccurredIndexes.Count; i++)
            {
                Console.WriteLine(listOfOccurredIndexes[i]);
            }
        }
    }
}
