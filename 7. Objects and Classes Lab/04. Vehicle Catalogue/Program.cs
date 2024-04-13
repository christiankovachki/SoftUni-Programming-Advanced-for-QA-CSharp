namespace _04._Vehicle_Catalogue
{
    internal class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Truck() { }

        public Truck(string brand, string model, string weight) 
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

        public Car() { }

        public Car(string brand, string model, string horsePower) 
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
    internal class Catalog
    {
        public List<Car> CarList { get; set; }
        public List<Truck> TruckList { get; set; }

        public Catalog() 
        {
            CarList = new List<Car>();
            TruckList = new List<Truck>();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] info = input.Split("/").ToArray();
                string vehicleType = info[0];
                string brand = info[1];
                string model = info[2];

                if (vehicleType == "Car")
                { 
                    string horsePower = info[3];
                    Car car = new Car(brand, model, horsePower);
                    catalog.CarList.Add(car);
                }
                else if (vehicleType == "Truck")
                {
                    string weigth = info[3];
                    Truck truck = new Truck(brand, model, weigth);
                    catalog.TruckList.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalog.CarList.Count != 0)
            {
                Console.WriteLine("Cars:");
                catalog.CarList
                    .OrderBy(c => c.Brand)
                    .Select(c =>
                    {
                        Console.WriteLine($"{c.Brand}: {c.Model} - {c.HorsePower}hp");

                        return 1;
                    })
                    .ToList();
            }

            if (catalog.TruckList.Count != 0)
            {
                Console.WriteLine("Trucks:");
                catalog.TruckList
                    .OrderBy(t => t.Brand)
                    .Select(t =>
                    {
                        Console.WriteLine($"{t.Brand}: {t.Model} - {t.Weight}kg");

                        return 1;
                    })
                    .ToList();
            }
        }
    }
}