string[] snacks = { "MySushi", "Dodo Pizza", "Burger King", "KFC", "McDonald's", "Hesburger", "Home made food" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");