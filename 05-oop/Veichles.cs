using People;

namespace Veichles;
class Bus
{
    public int Number { get; }
    public List<Person> Travellers { get; }

    public Bus(int number, List<Person> travellers) {
        this.Number = number;
        this.Travellers = travellers;
    }
}