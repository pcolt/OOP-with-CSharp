using Tickets;
using People;
using Veichles;

class Program 
{
    static void Main() {        
        var person1 = new Traveller("John", new SingleTicket());
        var person2 = new Traveller("Jane", new SingleTicket());
        var person3 = new Traveller("Alice", new SingleTicket());
        var person4 = new Traveller("Bob", new TicketBooklet());
        var person5 = new Traveller("Charlie");
        var firstBus = new Bus(1, new List<Traveller> { person1, person2, person3 });
        var secondBus = new Bus(2, new List<Traveller> { person3, person4, person5 });
        var inspector = new Inspector("Luis");
        
        Console.WriteLine($"{Environment.NewLine}Tickets bus number {firstBus.Number} before inspector stamps:");
        PrintStateTicketsInBus(firstBus);

        inspector.Salute();
        inspector.StampTicketsInBus(firstBus);
        Console.WriteLine($"Tickets bus number {firstBus.Number} after inspector has stamped:");
        PrintStateTicketsInBus(firstBus);

        Console.WriteLine($"{Environment.NewLine}Tickets bus number {secondBus.Number} before inspector {inspector.Name} stamps:");
        PrintStateTicketsInBus(secondBus);

        inspector.Salute();
        inspector.StampTicketsInBus(secondBus);
        Console.WriteLine($"Tickets bus number {secondBus.Number} after inspector has stamped:");
        PrintStateTicketsInBus(secondBus);

        Console.WriteLine($"{Environment.NewLine}Inspector {inspector.Name} has registered the following fines:");
        inspector.PrintFines();
    }

    static void PrintStateTicketsInBus(Bus bus) {
        foreach (var traveller in bus.Travellers) {
            traveller.Salute();
        }
    }
}
