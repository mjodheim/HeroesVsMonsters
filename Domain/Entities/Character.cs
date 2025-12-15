namespace Domain.Entities;

public abstract class Character
{
    // Propriétés en lecture seule
    public int BaseStrength { get; }
    public int BaseEndurance { get; }
    
    public int BaseHp { get; protected set; }
    public int CurrentHp { get; protected set; }

    protected Character()
    {
        BaseStrength = RollStat();
        BaseEndurance = RollStat();
        
        BaseHp = BaseEndurance + CaracModifier(BaseEndurance);
        CurrentHp =  BaseHp;
    }

    // Création d'un nouveau dé à 6 faces
    // Inutile de le créer à chaque fois → static
    public static De De6 = new De(1, 6);
    public static De De4 = new De(1, 4);
    
    private int RollStat()
    {
        // lancement des 4 dés à 6 faces
        var rolls = new int[]
        {
            De6.Lance(),
            De6.Lance(),
            De6.Lance(),
            De6.Lance(),
        };
        
        // on récupère les 3 meilleurs lancés des 4 lancés
        return rolls.OrderByDescending(r => r).Take(3).Sum();
    }

    protected int CaracModifier(int baseEndurance)
    {
        if (baseEndurance < 5) return -1;
        if (baseEndurance < 10) return 0;
        if (baseEndurance < 15) return 1;
        return 2;
    }
}