namespace Domain;

public class De
{
    public int Minimum { get; }
    public int Maximum { get; }

    private static readonly Random random = new Random();
    
    public De(int minimum, int maximum)
    {
        Minimum = minimum;
        Maximum = maximum;
    }

    public int Lance() => random.Next(Minimum, Maximum + 1);
}