namespace PR19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
        {
            "Сергей",
            "Егор",
            "Петр",
            "Ольга",
            "Семен",
            "Семен"
        };
            names.Sort();

            List<string> uniqueNames = RemoveDuplicates(names);

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
        static List<string> RemoveDuplicates(List<string> names)
        {
            List<string> uniqueNames = new List<string>();

            foreach (var name in names)
            {
                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                }
            }

            return uniqueNames;
        }
    }
}

