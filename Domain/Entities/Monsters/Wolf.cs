namespace Domain.Entities.Monsters;

public class Wolf : Monster
{
    public int Strength => BaseStrength;
    public int Endurance => BaseEndurance;

    public Wolf() : base(hasGold: false, canBeSkinned: true){ }
}