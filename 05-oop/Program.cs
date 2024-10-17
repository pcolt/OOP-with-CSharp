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
        foreach (var ticket in ticketsFirstRide) {
            Console.WriteLine(ticket.RidesLeft);
        }

        Console.WriteLine("Tickets first ride after stamping:");
        inspector.StampTickets(ticketsFirstRide);

        foreach (var ticket in ticketsFirstRide) {
            Console.WriteLine(ticket.RidesLeft);
        }

        Console.WriteLine("Tickets second ride before stamping:");
        foreach (var ticket in ticketsSecondRide) {
            Console.WriteLine(ticket.RidesLeft);
        }

        Console.WriteLine("Tickets second ride after stamping:");
        inspector.StampTickets(ticketsSecondRide);

        foreach (var ticket in ticketsSecondRide) {
            Console.WriteLine(ticket.RidesLeft);
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
// method that receives a list of ITicket and stamps them