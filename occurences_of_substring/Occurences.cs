using System;
using System.Collections.Generic;
using System.Xml;

namespace occurences_of_substring
{
    /// <summary>
    /// Implements ListOfOccurences method
    /// </summary>
    public class Occurences
    {
        /// <summary>
        /// Takes two strings and returns list of indexes where the sub string occured in main string
        /// </summary>
        /// <param name="originalString"></param>
        /// <param name="subString"></param>
        /// <returns name="listOfOccurredIndexes"></returns>
        public List<int> LIstOfOccurences(string originalString, string subString)
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
                            flag = false;  //if the characters of both string doesn't match, it says to break for loop and skips adding index to list
                            break;
                        }
                    }
                    if (flag)
                    {
                        listOfOccurredIndexes.Add(i);
                    }
                }
            }
            return listOfOccurredIndexes;
        }
    }
}
