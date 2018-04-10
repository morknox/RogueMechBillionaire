using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechsuit {
    Unit unit;
    Weapon[] weapons = new Weapon[2];
    List<Passive> passives = new List<Passive>();
    // List<Special> specials = new List<Special>(); // ? or 1
    Special special;

    public Mechsuit(Unit unit){
        this.unit = unit;

        //TEMP
        weapons[0] = new Weapon(unit, unit.body.Find("upperArmLeft").Find("underArmLeft").Find("barrel"));
        weapons[1] = new Weapon(unit, unit.body.Find("upperArmRight").Find("underArmRight").Find("barrel"));
        special = new Special(unit);
    }

    ~Mechsuit() {
    }

    void Equip(Weapon weapon, int index){
        //drop weapon[index]
        weapons[index] = weapon;

    }   

    public virtual void Update()
    {
        foreach (Weapon w in weapons)
        {
            w.Update();
        }
        foreach (Passive p in passives)
        {
            p.Update();
        }
        special.Update();
    }

    public virtual void Fire(int index)
    {
        weapons[index].Fire();
    }

    public virtual void FireAll()
    {
        foreach (Weapon w in weapons)
        {
            w.Fire();
        }
    }

    public virtual void Special()
    {
        special.Activate();
    }
}
