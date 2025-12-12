namespace PR19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            Dictionary<string, int> wordFrequency = CountWordFrequency(input);

            foreach (var kvp in wordFrequency)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        static Dictionary<string, int> CountWordFrequency(string text)
        {
            string[] words = text.ToLower().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {                 
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
            return wordCount;
        }
    }
}
