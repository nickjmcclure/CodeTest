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
        }
    }
}