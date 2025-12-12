namespace PR19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>
        {
            { "Батон", 15 },
            { "Буханка", 15 },
            { "Сырки", 9 },
            { "Чай", 15 },
            { "Кефир", 8 },
            { "ЧупаЧупс", 3 }
        };

            Dictionary<string, int> soledItems = new Dictionary<string, int>();

            SellItem(stock, soledItems, "Чай", 2);
            SellItem(stock, soledItems, "Кефир", 1);
            SellItem(stock, soledItems, "Буханка", 1);

            Console.WriteLine("Остаток:");
            foreach (var item in stock)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("\nПроданные товары:");
            foreach (var soldItem in soledItems)
            {
                Console.WriteLine($"{soldItem.Key}: {soldItem.Value} раз");
            }
        }

        static void SellItem(Dictionary<string, int> stock, Dictionary<string, int> soledItems, string itemName, int quantity)
        {
            if (stock.ContainsKey(itemName))
            {
                if (stock[itemName] >= quantity)
                {
                    stock[itemName] -= quantity;

                    if (soledItems.ContainsKey(itemName))
                    {
                        soledItems[itemName] += quantity;
                    }
                    else
                    {
                        soledItems[itemName] = quantity;
                    }
                }
                else
                {
                    Console.WriteLine($"Товара '{itemName}' мало в наличии.");
                }
            }
            else
            {
                Console.WriteLine($"Товара '{itemName}' нет в наличии.");
            }
        }
    }
}

