using Tickets;
using People;
using Veichles;

class Program 
{
    static void Main() {
        // var ticket1 = new SingleTicket();
        var person1 = new Person("John", new SingleTicket());
        // var ticket2 = new SingleTicket();
        var person2 = new Person("Jane", new SingleTicket());
        // var ticket3 = new SingleTicket();
        var person3 = new Person("Alice", new SingleTicket());
        // var ticket4 = new TicketBooklet();
        var person4 = new Person("Bob", new TicketBooklet());
        var person5 = new Person("Charlie");
        // var ticketsFirstRide = new List<ITicket> { ticket1, ticket2, ticket3, ticket4 };
        var firstBus = new Bus(1, new List<Person> { person1, person2, person3 });
        // var ticketsSecondRide = new List<ITicket> { ticket3, ticket4 };
        var secondBus = new Bus(2, new List<Person> { person3, person4, person5 });
        var inspector = new Inspector();
        
        Console.WriteLine($"{Environment.NewLine}Tickets bus number {firstBus.Number} before inspector stamps:");
        // PrintRidesLeft(ticketsFirstRide);
        PrintStateTicketsInBus(firstBus);

        // inspector.StampTickets(ticketsFirstRide);
        Console.WriteLine($"Tickets bus number {secondBus.Number} inspector starts stamping...");
        inspector.StampTicketsInBus(firstBus);
        // PrintRidesLeft(ticketsFirstRide);
        Console.WriteLine($"Tickets bus number {firstBus.Number} after inspector has stamped:");
        PrintStateTicketsInBus(firstBus);

        Console.WriteLine($"{Environment.NewLine}Tickets bus number {secondBus.Number} before inspector stamps:");
        // PrintRidesLeft(ticketsSecondRide);
        PrintStateTicketsInBus(secondBus);

        Console.WriteLine($"Tickets bus number {secondBus.Number} inspector starts stamping...");
        inspector.StampTicketsInBus(secondBus);
        Console.WriteLine($"Tickets bus number {secondBus.Number} after inspector has stamped:");
        PrintStateTicketsInBus(secondBus);

        Console.WriteLine($"{Environment.NewLine}Fines:");
        inspector.PrintFines();
    }

    static void PrintRidesLeft(List<ITicket> tickets) {
        for (int i = 0; i < tickets.Count; i++) {
            Console.WriteLine($"Ticket {i} rides left: {tickets[i].RidesLeft}");
        }
    }

    static void PrintStateTicketsInBus(Bus bus) {
        foreach (var person in bus.Travellers) {
            if (person.Ticket == null) {
                Console.WriteLine($"{person.Name} has no ticket");
                continue;
            }
            Console.WriteLine($"{person.Name} has ticket with {person.Ticket.RidesLeft} rides left");
        }
    }
}
