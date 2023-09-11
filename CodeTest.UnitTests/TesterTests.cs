using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace CodeTest.Tests
{
    [TestClass]
    public class TesterTests
    {
        [TestMethod]
        [DataRow("abcba", true)]
        [DataRow("racecar", true)]
        [DataRow("hello", false)]
        [DataRow("", true)]
        public void IsPalindrome(string input, bool expectedOutput)
        {
            bool output = Tester.IsPalindrome(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [DataRow("abca", new char[] { 'a', 'b', 'c' }, new int[] { 2, 1, 1 })]
        [DataRow("hello", new char[] { 'h', 'e', 'l', 'o' }, new int[] { 1, 1, 2, 1 })]
        [DataRow("", new char[] { }, new int[] { })]
        public void CharacterCount(string input, char[] expectedKeys, int[] expectedValues)
        {            
            Dictionary<char, int> output = Tester.CharacterCount(input);

            CollectionAssert.AreEqual(expectedKeys, new List<char>(output.Keys).ToArray());
            CollectionAssert.AreEqual(expectedValues, new List<int>(output.Values).ToArray());
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 4, 5 }, new int[] { 3 })]
        public void GetMatches(int[] input1, int[] input2, int[] expected)
        {
            int[] result = Tester.GetMatches(input1, input2);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 4, 5 }, new int[] {1, 2, 4, 5 })]
        public void GetDiff(int[] input1, int[] input2, int[] expected)
        {
            int[] result = Tester.GetDiff(input1, input2);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}