delegate bool SmartphoneFilter(Smartphone s);

delegate void PrintDelegate(string text);

class Program
{
    static void Main()
    {
        // PrintDelegate Print = (string text) => Console.WriteLine(text);
        Action<string> Print = (string text) => Console.WriteLine(text);
        // PrintDelegate PrintToFile = (string text) => File.AppendAllText("output.txt", text);
        Action<string> PrintToFile = (string text) => File.AppendAllText("output.txt", text);
        Print("Hello, World!");
        // static void ConnectToDatabase(PrintDelegate log) {
        static void ConnectToDatabase(Action<string> log) {
            // Do The insertion
            log("Inserting data into database...");
            // insertion done
            log("Data inserted successfully!");
        }
        ConnectToDatabase(Print);

        // SmartphoneFilter filter = isCheap;
        SmartphoneFilter isCheap = (smartphone) => {
            return smartphone.Price > 1000;
        };
        var isIphone14Cheap = isCheap(new Smartphone { Brand = "Apple", Model = "iPhone 14", Year = 2022, Price = 1600M }); 
        Console.WriteLine($"Is iPhone 14 cheap? {isIphone14Cheap}");

        Func<Smartphone, bool> isCheap2 = (smartphone) => {
            return smartphone.Price > 1000;
        };
        var isIphone14Cheap2 = isCheap2(new Smartphone { Brand = "Apple", Model = "iPhone 14", Year = 2022, Price = 1600M }); 
        Console.WriteLine($"Is iPhone 14 cheap? {isIphone14Cheap2}");

        Func<List<Smartphone>, SmartphoneFilter, List<Smartphone>> FilterSmartphones = (smartphones, filter) => {
            var result = new List<Smartphone>();
            foreach (var smartphone in smartphones) {
                if (filter(smartphone)) {
                    result.Add(smartphone);
                }
            }
            return result;
        };
        var smartphones = CreateSmartphones();
        var expensiveSmartphones = FilterSmartphones(smartphones, isCheap);
        foreach (var smartphone in expensiveSmartphones) {
            Console.WriteLine($"{smartphone.CompleteName} is expensive!");
        }
    }

    static List<Smartphone> CreateSmartphones() {
        return new List<Smartphone> {
            Smartphone.Create("Apple", "iPhone 14", 2022, 1600M),
            Smartphone.Create("Apple", "iPhone 13", 2020, 1499.99M),
            Smartphone.Create("Samsung", "S22", 2022, 1399.99M),
            Smartphone.Create("Samsung", "A50", 2018, 299M),
            Smartphone.Create("Huawei", "P20 Mate", 2019, 899.95M),
            Smartphone.Create("Nokia", "3310", 1999, 207.03M),
            Smartphone.Create("Xiaomi", "11T Pro", 2020, 600),
            Smartphone.Create("Oppo", "A53", 2020, 179.89M),
        };
    }

}

class Smartphone
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string CompleteName {
        get {
            return $"{Brand} {Model}";
        }
    }
    public int Age {
        get {
            return DateTime.Now.Year - Year;
        }
    }

    public Smartphone() { }

    public static Smartphone Create(string brand, string model, int year, decimal price) {
        return new Smartphone {
            Brand = brand,
            Model = model,
            Year = year,
            Price = price,
        };
    }
}