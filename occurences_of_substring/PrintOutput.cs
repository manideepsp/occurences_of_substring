using System;
using System.Collections.Generic;

namespace occurences_of_substring
{
    /// <summary>
    /// Implements OutPut method
    /// </summary>
    public class PrintOutput
    {
        /// <summary>
        /// Console.Write()'s the list in a formatted way
        /// </summary>
        /// <param name="listOfOccurredIndexes"></param>
        public void OutPut(List<int> listOfOccurredIndexes)
        {
            for(int i=0; i<listOfOccurredIndexes.Count; i++)
            {
                Console.Write(listOfOccurredIndexes[i]+" ");
            }
        }

        /// <summary>
        /// Prints error message
        /// </summary>
        public void ErrorMessage()
        {
            Console.WriteLine("Wrong Input");
        }
    }
}
