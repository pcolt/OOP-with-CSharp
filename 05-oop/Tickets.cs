namespace Tickets;

interface ITicket
{
    int RidesLeft { get; }
    bool IsValid { get; }
    void Stamp();
}

class SingleTicket : ITicket
{
    public int RidesLeft { get; private set; } = 1;
    public bool IsValid { get { return RidesLeft > 0; } }
    public void Stamp() {
        if (RidesLeft == 0) {
            throw new Exception("Ticket has no rides left!");
        }
        RidesLeft -= 1;
    }
}

class TicketBooklet : ITicket
{
    public int RidesLeft { get; private set; } = 10;
    public bool IsValid { get { return RidesLeft > 0; } }

    public void Stamp() {
        if (RidesLeft == 0) {
            throw new Exception("Ticket has no rides left!");
        }
        RidesLeft -= 1;
    }
}