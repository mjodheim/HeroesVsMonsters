namespace Domain.Entities;

public abstract class Monster : Character
{
    public int Gold { get; protected set; }
    public int Leather { get; protected set; }

    protected Monster() : base() { }
    
    protected Monster(bool hasGold, bool canBeSkinned)
    {
        Gold = hasGold ? De6.Lance() : 0;
        Leather = canBeSkinned ? De4.Lance() : 0;
    }
}