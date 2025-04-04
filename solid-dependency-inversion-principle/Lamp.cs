public class Lamp : ISwitchable {
    private bool isOn = false;
    public void Toggle() {
        isOn = !isOn;
        Console.WriteLine($"Lamp is {(isOn ? "On" : "Off")}");
    }
}