namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            while (!input.Equals("buy"))
            {
                string[] info = input.Split().ToArray();
                string name = info[0];
                double price = double.Parse(info[1]);
                int quantity = int.Parse(info[2]);

                if (products.ContainsKey(name))
                {
                    double currentPrice = products[name].Keys.ElementAt(0);
                    int currentQuantity = products[name].Values.ElementAt(0);
                    
                    products[name].Remove(currentPrice);
                    products[name].Add(price, quantity + currentQuantity);
                }
                else
                {
                    products.Add(name, new Dictionary<double, int>());
                    products[name].Add(price, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double price = item.Value.ElementAt(0).Key;
                int quantity = item.Value.ElementAt(0).Value;

                double totalPrice = price * quantity;

                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
            }

            // Using LINQ
            //products.Select(p => { Console.WriteLine($"{p.Key} -> {(p.Value.ElementAt(0).Key * p.Value.ElementAt(0).Value):F2}"); return 1; }).ToArray();
        }
    }
}