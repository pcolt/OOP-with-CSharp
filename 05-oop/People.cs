using Tickets;
using Veichles;

namespace People;
class Inspector
{
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
            if (person.Ticket.IsValid == false) {
                Console.WriteLine($"Oh no! {person.Name} has no rides left!");
                continue;
            }
            person.Ticket.Stamp();
        }
    }
}

class Person
{
    public string Name { get; }
    public ITicket Ticket { get; set; }

    public Person(string name, ITicket ticketType) {
        this.Name = name;
        this.Ticket = ticketType; 
    }
}