using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class RemoteControlCar
{

    private int speed;
    private int batteryDrain;
    private int metersDriven;
    private int currentBattery = 100; 

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained() => this.batteryDrain>this.currentBattery;

    public int DistanceDriven() => this.metersDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.currentBattery-=this.batteryDrain;
            this.metersDriven+=this.speed;
        }
    }

    public int getSpeed() => this.speed;

    public int getBatteryDrain() => this.batteryDrain;

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int trackDistance;

    public RaceTrack(int trackDistance) => this.trackDistance = trackDistance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int speed = car.getSpeed();
        int batteryDrain = car.getBatteryDrain();

        return (trackDistance % (speed*batteryDrain) == 0);
    }
}
