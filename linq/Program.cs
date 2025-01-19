class Program {
    static void Main() {
        var strings1 = new [] {
            "1",
            "",
            "pippo",
            "2",
            "4",
            "17",
            "nope",
            "21",
        };

        var result = strings1
            .Where(s => s.Length > 0 && int.TryParse(s, out _))
            .Select(int.Parse)
            .Select(i => i * 3)
            .GroupBy(i => i % 2 == 0)
            .Select(g => new {
                IsEven = g.Key,
                numbers = g.ToList()
                });
                
        
        foreach (var item in result) {
            Console.WriteLine(item);
            foreach (var number in item.numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
