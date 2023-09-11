namespace CodeTest
{
    internal class Program
    {
        static void Main()
        {
            List<string> testStrings = new()
            {
                "abcba",
                "racecar",
                "hello",
                "sitonapotatopanotis",
            };

            Console.WriteLine("IsPalindrome Tests:");
            foreach (string testString in testStrings)
            {
                Console.WriteLine($"IsPalindrome(\"{testString}\") = {Tester.IsPalindrome(testString)}");
            }

            
            Console.WriteLine("\nCharacterCount Tests:");
            foreach (string testString in testStrings)
            {
                Console.WriteLine($"CharacterCount(\"{testString}\")");
                foreach (KeyValuePair<char, int> kvp in Tester.CharacterCount(testString))
                {
                    Console.WriteLine($"\t{kvp.Key} : {kvp.Value}");
                }
            }


            int[] testArray1 = new int[] { 1, 2, 3 };
            int[] testArray2 = new int[] { 3, 4, 5 };

            Console.WriteLine("\nGetMatches Tests:");
            Console.WriteLine($"GetMatches(({string.Join(", ", testArray1)}), ({string.Join(", ", testArray2)})) = {string.Join(", ", Tester.GetMatches(testArray1, testArray2))}");

            Console.WriteLine("\nGetDiff Tests:");
            Console.WriteLine($"GetDiff(({string.Join(", ", testArray1)}), ({string.Join(", ", testArray2)})) = {string.Join(", ", Tester.GetDiff(testArray1, testArray2))}");
        }
    }
}