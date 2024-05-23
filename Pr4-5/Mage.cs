using System;
using System.Collections.Generic;

public abstract class Mage
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int MagicLevel { get; private set; }
    protected List<ISpell> Spells { get; private set; }

    public Mage(string name, int magicLevel)
    {
        Name = name;
        MagicLevel = magicLevel;
        Health = 100;
        Spells = new List<ISpell>();
    }

    public void AddSpell(ISpell spell)
    {
        Spells.Add(spell);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public abstract void Attack(Mage target);

    public bool IsAlive()
    {
        return Health > 0;
    }
}


public class FireMage : Mage
{
    public FireMage(string name, int magicLevel) : base(name, magicLevel = 4)
    {
        AddSpell(new Fireball());
    }

    public override void Attack(Mage target)
    {
        if (Spells.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} attacks {target.Name}!");
            Spells[0].Cast(target, MagicLevel);
        }
    }
}

public class WaterMage : Mage
{
    public WaterMage(string name, int magicLevel) : base(name, magicLevel = 5)
    {
        AddSpell(new WaterBlast());
    }

    public override void Attack(Mage target)
    {
        if (Spells.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} attacks {target.Name}!");
            Spells[0].Cast(target, MagicLevel);
        }
    }
}

public class BananaMage : Mage
{
    public BananaMage(string name, int magicLevel) : base(name, magicLevel = 2)
    {
        AddSpell(new MonkeySummon());
    }

    public override void Attack(Mage target)
    {
        if (Spells.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} attacks {target.Name}!");
            foreach (var spell in Spells)
            {
                spell.Cast(target, MagicLevel);
            }
        }
    }
}
