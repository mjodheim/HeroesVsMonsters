namespace Domain.Entities.Monsters;

public class Dragonling : Monster
{
    public int Strength => BaseStrength;
    public int Endurance => BaseEndurance + 1;
    
    public  Dragonling() : base(hasGold: true, canBeSkinned: true) {}
}