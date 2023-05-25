using System;

namespace occurences_of_substring
{
    /// <summary>
    /// Implements edge cases method
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Check with edge cases and throw an error
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="Exception"></exception>
        public bool EdgeCases(string originalString, string subString)
        {
            bool flag = false;
            if (originalString == null || subString == null)
            {
                string nullString = String.Empty;

                if (originalString == null)
                {
                    nullString += "originalString ";
                }
                if (subString == null)
                {
                    nullString += "subString";
                }
                flag = true;
                throw new ArgumentNullException(nullString + " is null");
            }
            if (originalString.Length < subString.Length)
            {
                flag = true;
                throw new ArgumentException("subString length should be smaller than originalString");
            }
            return flag;
        }
    }
}
