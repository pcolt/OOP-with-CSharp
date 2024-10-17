namespace Tickets;

interface ITicket
{
    int RidesLeft { get; }
    void Stamp();
}

class SingleTicket : ITicket
{
    public int RidesLeft { get; private set; } = 1;

    public void Stamp() {
        if (RidesLeft == 0) {
            Console.WriteLine("Oh no! Ticket has no rides left!");
            return;
        }
        RidesLeft -= 1;
    }
}

class TicketBooklet : ITicket
{
    public int RidesLeft { get; private set; } = 10;

    public void Stamp() {
        if (RidesLeft == 0) {
            Console.WriteLine("Oh no! Ticket has no rides left!");
            return;
        }
        RidesLeft -= 1;
    }
}