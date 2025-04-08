using interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IAttack> attackers = new List<IAttack>
        {
            new Melee(),
            new Ranger()
        };

        List<IDefend> defenders = new List<IDefend>
        {
            new Melee(),
            new Support()
        };

        List<IHeal> healers = new List<IHeal>
        {
            new Ranger(),
            new Support()
        };

        Console.WriteLine("Attackers:");
        foreach (var attacker in attackers)
        {
            attacker.Attack();
        }

        Console.WriteLine("\nDefenders:");
        foreach (var defender in defenders)
        {
            defender.Defend();
        }

        Console.WriteLine("\nHealers:");
        foreach (var healer in healers)
        {
            healer.Heal();
        }
    }
}