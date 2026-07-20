static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double[] successRates = [0, 1, 1, 1, 1, 0.9, 0.9, 0.9, 0.9, 0.8, 0.77];

        return successRates[speed];
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
