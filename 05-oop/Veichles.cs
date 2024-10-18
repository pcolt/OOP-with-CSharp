using People;

namespace Veichles;
class Bus
{
    public int Number { get; }
    public List<Traveller> Travellers { get; }

    public Bus(int number, List<Traveller> travellers) {
        this.Number = number;
        this.Travellers = travellers;
    }
}