using System;

public interface ISpell
{
    void Cast(Mage target, int magicLevel);
}

public abstract class Spell : ISpell
{
    protected virtual int BaseDamage { get; }
    protected virtual double HitChance { get; }
    protected virtual string Message { get; } = string.Empty;

    private static readonly Random random = new();

    public virtual void Cast(Mage target, int magicLevel)
    {
        if (random.NextDouble() <= HitChance)
        {
            int damage = CalculateDamage(magicLevel);
            Console.WriteLine($"{Message} {GetType().Name} hits {target.Name} for {damage} damage!");
            target.TakeDamage(damage);
        }
        else
        {
            Console.WriteLine($"{GetType().Name} missed {target.Name}!");
        }
    }

    protected virtual int CalculateDamage(int magicLevel)
    {
        return BaseDamage + (magicLevel / 2);
    }
}

public class Fireball : Spell
{
    protected override int BaseDamage { get; } = 20;
    protected override double HitChance { get; } = 0.8;
    protected override string Message { get; } = "Boom!";

}

public class WaterBlast : Spell
{
    protected override int BaseDamage { get; } = 15;
    protected override double HitChance { get; } = 0.9;
    protected override string Message { get; } = "Splash!";

}

public class MonkeySummon : Spell
{
    protected override int BaseDamage { get; } = 30;
    protected override double HitChance { get; } = 0.7;
    protected override string Message { get; } = "Out of nowhere an evil monkey appeared and";

}
