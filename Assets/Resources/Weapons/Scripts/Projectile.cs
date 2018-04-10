using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    Unit unit;
    Rigidbody rb;
    float speed, damage;

	void Start () {
    
	}

    public void Initialize(Unit unit, float speed, float damage)
    {
        rb = GetComponent<Rigidbody>();
        this.unit = unit;
        this.speed = speed;
        this.damage = damage;
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
