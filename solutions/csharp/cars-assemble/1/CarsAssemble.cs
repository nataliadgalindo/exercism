static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double[] successRates = [0, 1, 1, 1, 1, 0.9, 0.9, 0.9, 0.9, 0.8, 0.77];

        return successRates[speed];
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rate = speed * 221 * SuccessRate(speed);
        return rate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int items = (int)ProductionRatePerHour(speed) / 60;
        return items;
    }
}
