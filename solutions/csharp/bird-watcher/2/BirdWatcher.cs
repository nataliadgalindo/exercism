class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => [0,2,5,3,7,8,4];

    public int Today() => this.birdsPerDay[^1];

    public void IncrementTodaysCount() => this.birdsPerDay[^1] ++;

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in this.birdsPerDay)
        {
            if (birds == 0) return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            count += this.birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays()
    {
        int count = 0;

        foreach (int birds in this.birdsPerDay)
        {
            if (birds >= 5) count ++;
        }

        return count;
    }
}
