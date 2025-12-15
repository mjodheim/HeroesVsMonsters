namespace Domain.Entities;

public class Hero : Character
{
    public int Gold { get; protected set; }
    public int Leather { get; protected set; }
    
    protected Hero() : base() { }

    public void AddLoot(int gold, int leather)
    {
        Gold += gold;
        Leather += leather;
    }
    
}