﻿class Program 
{
    static void Main() {
        var ticket1 = new SingleTicket();
        var ticket2 = new SingleTicket();
        var ticket3 = new SingleTicket();
        var tickets = new List<ITicket> { ticket1, ticket2, ticket3 };
        var inspector = new Inspector();
        
        Console.WriteLine("Tickets before stamping:");
        foreach (var ticket in tickets) {
            Console.WriteLine(ticket.IsStamped);
        }

        inspector.StampTickets(tickets);

        Console.WriteLine("Tickets after stamping:");
        foreach (var ticket in tickets) {
            Console.WriteLine(ticket.IsStamped);
        }
    }
}

interface ITicket
{
    bool IsStamped { get; }
    void Stamp();
}

class SingleTicket : ITicket
{
    public bool IsStamped { get; private set; } = false;

    // public SingleTicket() {
    //     IsStamped = false;
    // }

    public void Stamp() {
        IsStamped = true;
    }
}

// class TicketBooklet : ITicket

class Inspector
{
    public void StampTickets(List<ITicket> tickets) {
        foreach (var ticket in tickets) {
            ticket.Stamp();
        }
    }
}
// method that receives a list of ITicket and stamps them