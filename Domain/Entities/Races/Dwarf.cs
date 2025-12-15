namespace Domain.Entities.Races;

public class Dwarf : Hero
{
    public int Strength => BaseStrength;
    public int Endurance => BaseEndurance + 2;
    
}