using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechsuit {

    List<Weapon> weapons = new List<Weapon>();
    List<Passive> passives = new List<Passive>();
    // List<Special> specials = new List<Special>(); // ? or 1
    Special special;
    Mechsuit(){
    }

    ~Mechsuit() {
    }

    public void Update()
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

    public void Fire(int index)
    {

        weapons[index].Fire();
    }

    public void FireALL()
    {
        foreach (Weapon w in weapons)
        {
            w.Fire();
        }
    }

    public void Special()
    {
        special.Activate();
    }
}
