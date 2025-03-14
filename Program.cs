namespace AnagramAndNoRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assignment 2*/
            // Test the function
            Console.WriteLine(FörstaIckeRepeterandeTecken("swiss")); // w
            Console.WriteLine(FörstaIckeRepeterandeTecken("racecars")); // e
            Console.WriteLine(FörstaIckeRepeterandeTecken("aabb")); // _

        }

        public static char FörstaIckeRepeterandeTecken(string text)
        {
            // Dictionary to store character counts
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // First pass: Count occurrences of each character
            foreach (char c in text)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Second pass: Find the first character with a count of 1
            foreach (char c in text)
            {
                if (charCount[c] == 1)
                    return c;
            }

            // If no unique character is found, return '_'
            return '_';
        }
    }
}
