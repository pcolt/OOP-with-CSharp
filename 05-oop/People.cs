using Tickets;
using Veichles;

namespace People;

abstract class Person
{
    public string Name { get; }
    protected Person(string name) {
        Name = name;
    }
}

class Inspector: Person
{
    public Inspector(string name) : base(name) {}

    public List<Fine> Fines { get; private set; } = new List<Fine>();
    public void StampTickets(List<ITicket> tickets) {
        foreach (var ticket in tickets) {
            if (ticket.IsValid == false) {
                Console.WriteLine("Oh no! This ticket has no rides left!");
                continue;
            }
            ticket.Stamp();
        }
    }
    
    public void StampTicketsInBus(Bus bus) {
        foreach (var person in bus.Travellers) {
            if (person.Ticket == null) {
                Console.WriteLine($"{person.Name} has no ticket!");
                Fines.Add(new Fine(100, person));
                continue;
            } else if (person.Ticket.IsValid == false) {
                Console.WriteLine($"Oh no! {person.Name} has no rides left!");
                Fines.Add(new Fine(80, person));
                continue;
            }
            person.Ticket.Stamp();
        }
    }

    public void PrintFines() {
        foreach (var fine in Fines) {
            Console.WriteLine($"Fine of {fine.Amount} to {fine.Traveller.Name}");
        }
    }
}

class Fine
{
    public int Amount { get; }
    public Traveller Traveller { get; }
    public Fine(int amount, Traveller person) {
        this.Amount = amount;
        this.Traveller = person;
    }
}

class Traveller: Person
{
    public ITicket? Ticket { get; set; }

    public Traveller(string name, ITicket ticketType) : base(name) {
        this.Ticket = ticketType; 
    }

    public Traveller (string name) : base(name) {
        this.Ticket = null;
    }
}