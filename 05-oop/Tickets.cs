namespace Tickets;

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