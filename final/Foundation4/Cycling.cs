class Cycling : Activity

{
    private double speed;

    public Cycling(string date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} miles, Speed: {speed:F2} mph, Pace: {GetPace():F2} min/mile";
    }
}
