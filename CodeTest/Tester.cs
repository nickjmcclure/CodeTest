using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
            return false;  // Expected: IsPalindrome(null) => False, IsPalindrome("") => False
            }

            string reversed = new string(input.Reverse().ToArray());
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
            }
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="inpput">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each charter as the value</returns>
        public static Dictionary<char, int> CharacterCount(string inpput)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();
            if (input == null)
            {
                 return output; 
            }

            foreach (char c in input)
                {
                if (output.ContainsKey(c))
                {
                    output[c]++;
                }
                else
                {
                    output[c] = 1;
                }        
            }

                return output;
            }
    }

    return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
             if (input1 == null || input2 == null)
            {        
                return new int[0];  // Expected: GetMatches(null, [1, 2, 3]) => []
            }
            return input1.Intersect(input2).ToArray();  // Expected: GetMatches([1, 2, 3], [3, 4, 5]) => [3], GetMatches([1, 2, 3], [4, 5, 6]) => []
        }

        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
           if (input1 == null || input2 == null)
            {
            return new int[0];  // Expected: GetDiff(null, [1, 2, 3]) => []
            }
            return input1.Except(input2).Concat(input2.Except(input1)).ToArray();  // Expected: GetDiff([1, 2, 3], [3, 4, 5]) => [1, 2, 4, 5], GetDiff([1, 2, 3], [4, 5, 6]) => [1, 2, 3, 4, 5, 6]
        }
        }
    }
}
