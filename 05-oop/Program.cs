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
        // var ticketsFirstRide = new List<ITicket> { ticket1, ticket2, ticket3, ticket4 };
        var firstBus = new Bus(1, new List<Person> { person1, person2, person3});
        // var ticketsSecondRide = new List<ITicket> { ticket3, ticket4 };
        var secondBus = new Bus(2, new List<Person> { person3, person4 });
        var inspector = new Inspector();
        
        Console.WriteLine($"{Environment.NewLine}Tickets bus number {firstBus.Number} before inspector stamps:");
        // PrintRidesLeft(ticketsFirstRide);
        PrintStateTicketsInBus(firstBus);

        Console.WriteLine($"Tickets bus number {firstBus.Number} after inspector stamps:");
        // inspector.StampTickets(ticketsFirstRide);
        inspector.StampTicketsInBus(firstBus);
        // PrintRidesLeft(ticketsFirstRide);
        PrintStateTicketsInBus(firstBus);

        Console.WriteLine($"{Environment.NewLine}Tickets bus number {secondBus.Number} before inspector stamps:");
        // PrintRidesLeft(ticketsSecondRide);
        PrintStateTicketsInBus(secondBus);

        Console.WriteLine($"Tickets bus number {secondBus.Number} after inspector stamps:");
        inspector.StampTicketsInBus(secondBus);
        PrintStateTicketsInBus(secondBus);
    }

    static void PrintRidesLeft(List<ITicket> tickets) {
        for (int i = 0; i < tickets.Count; i++) {
            Console.WriteLine($"Ticket {i} rides left: {tickets[i].RidesLeft}");
        }
    }

    static void PrintStateTicketsInBus(Bus bus) {
        foreach (var person in bus.Travellers) {
            Console.WriteLine($"{person.Name} has ticket with {person.Ticket.RidesLeft} rides left");
        }
    }
}
