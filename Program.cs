namespace AnagramAndNoRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assignment 1*/

            // Test Function
            var input = new List<string> { "listen", "silent", "enlist", "rat", "god", "tar", "art", "evil", "vile", "live", "dog" };
            var resultat = GrupperaAnagram(input);


            // Print result
            foreach (var grupp in resultat)
            {
                Console.WriteLine(string.Join(", ", grupp));
            }
        }

        public static List<List<string>> GrupperaAnagram(List<string> ordLista)
        {
            // Dictionary to group words by their sorted character representation
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (var word in ordLista)
            {
                // Sort the characters in the word to create a unique key for anagrams
                string sortedWord = new string(word.OrderBy(c => c).ToArray());

                // Add the word to the appropriate group in the dictionary
                if (!anagramGroups.ContainsKey(sortedWord))
                {
                    anagramGroups[sortedWord] = new List<string>();
                }
                anagramGroups[sortedWord].Add(word);
            }

            // Convert dictionary values to a list of lists
            return anagramGroups.Values.ToList();
        }
    }
}
