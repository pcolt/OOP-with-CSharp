public class Button {
    private readonly ISwitchable switchableDevice;

    public Button(ISwitchable switchable) {
        switchableDevice = switchable;
    }

    public void Click() {
        switchableDevice.Toggle();
    }
}