using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon {
    public static Object projectile;
    Unit unit;
    float damage, firerate, bulletSpeed;
    Transform barrel;
    float counter = 0;

    static Weapon()
    {
        projectile = Resources.Load("Weapons/Prefabs/Projectile");
    }

    public Weapon(Unit unit, Transform barrel){
        this.unit = unit;
        this.barrel = barrel;
        damage = 5;
        firerate = 0.1f;
        bulletSpeed = 15;
    }

    ~Weapon()
    {

    }
    public virtual void Update()
    {
        if (counter > 0)
        {
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                counter = 0;
            }
        }
    }

    public virtual void Reload()
    {

    }
    public virtual void Fire()
    {
        if (counter == 0)
        {
            GameObject go = Object.Instantiate(projectile, barrel.position, Quaternion.LookRotation(unit.aimDirection, Vector3.up)) as GameObject;
            //  go.GetComponent<Spear>().gladiator = gladiator;
            //go.GetComponent<Spear>().damage = gladiator.spearDamage;
            Rigidbody rb = go.GetComponent<Rigidbody>();
            (go.GetComponent<Projectile>()).Initialize(unit, bulletSpeed, damage);
            counter = firerate;
        }
    }
}
