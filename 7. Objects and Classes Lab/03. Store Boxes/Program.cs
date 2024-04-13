namespace _03._Store_Boxes
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item() { }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    internal class Box
    {
       public string SerialNumber { get; set; }
       public Item Item { get; set; }
       public int Quantity { get; set; }
       public double PriceOfABox { get; set; }

       public Box() { }

       public Box(string serialNumber, Item item, int itemQuantity) 
       {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = itemQuantity;
            PriceOfABox = item.Price * itemQuantity;
       }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end") 
            {
                string[] data = input.Split().ToArray();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes.OrderByDescending(b => b.PriceOfABox)
                .Select(b =>
                    {
                        Console.WriteLine(b.SerialNumber);
                        Console.WriteLine($"-- {b.Item.Name} - ${b.Item.Price:F2}: {b.Quantity}");
                        Console.WriteLine($"-- ${b.PriceOfABox:F2}");

                        return 1;
                    })
                .ToList();

            // Same output but with foreach
            //boxes = boxes.OrderByDescending(b => b.PriceOfABox).ToList();
            //foreach (var box in boxes)
            //{
            //    Console.WriteLine(box.SerialNumber);
            //    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
            //    Console.WriteLine($"-- ${box.PriceOfABox:F2}");
            //}
        }
    }
}