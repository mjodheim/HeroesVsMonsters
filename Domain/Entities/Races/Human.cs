namespace Domain.Entities.Races;

public class Human : Hero
{
    public int Strength => BaseStrength + 1;
    public int Endurance => BaseEndurance + 1;
    
}