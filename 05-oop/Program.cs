using Tickets;

class Program 
{
    static void Main() {
        var ticket1 = new SingleTicket();
        var ticket2 = new SingleTicket();
        var ticket3 = new SingleTicket();
        var ticket4 = new TicketBooklet();
        var ticketsFirstRide = new List<ITicket> { ticket1, ticket2, ticket3, ticket4 };
        var ticketsSecondRide = new List<ITicket> { ticket3, ticket4 };
        var inspector = new Inspector();
        
        Console.WriteLine("Tickets first ride before stamping:");
        PrintRidesLeft(ticketsFirstRide);

        Console.WriteLine("Tickets first ride after stamping:");
        inspector.StampTickets(ticketsFirstRide);
        PrintRidesLeft(ticketsFirstRide);

        Console.WriteLine("Tickets second ride before stamping:");
        PrintRidesLeft(ticketsSecondRide);

        Console.WriteLine("Tickets second ride after stamping:");
        inspector.StampTickets(ticketsSecondRide);
        PrintRidesLeft(ticketsSecondRide);
    }

    static void PrintRidesLeft(List<ITicket> tickets) {
        for (int i = 0; i < tickets.Count; i++) {
            Console.WriteLine($"Ticket {i} rides left: {tickets[i].RidesLeft}");
        }
    }
}

class Inspector
{
    public void StampTickets(List<ITicket> tickets) {
        foreach (var ticket in tickets) {
            ticket.Stamp();
        }
    }
}
