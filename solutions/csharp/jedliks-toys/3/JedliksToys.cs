class RemoteControlCar
{
    private int _distanceDriven;
    private int _currentBattery = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => _currentBattery == 0 ? "Battery empty" : $"Battery at {_currentBattery}%";

    public void Drive()
    {
        if (_currentBattery != 0)
        {
            _distanceDriven += 20;
            _currentBattery -= 1;
        }
    }
}
