namespace Domain.Entities.Monsters;

public class Orc : Monster
{
    public int Strength => BaseStrength + 1;
    public int Endurance => BaseEndurance;
    
    public  Orc() : base(hasGold: true, canBeSkinned: false) {}
}